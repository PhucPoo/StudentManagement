using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Infrastructure.Data;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.StudentManagement.Core.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Xem danh sách người dùng
        public async Task<List<UserReponseDTO>> GetAllAsync()
        {
            var users = await _context.Users.ToListAsync();
            return _mapper.Map<List<UserReponseDTO>>(users);
        }

        // Thêm tài khoản mới
        public async Task<UserReponseDTO> CreateAsync(UserRequestDTO dto)
        {
            var user = _mapper.Map<User>(dto);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserReponseDTO>(user);
        }

        // Cập nhật tài khoản
        public async Task<UserReponseDTO> UpdateAsync(int id, UserRequestDTO dto)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return null;

            _mapper.Map(dto, user);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserReponseDTO>(user);
        }

        // Xóa tài khoản
        public async Task<bool> DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return false;
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
