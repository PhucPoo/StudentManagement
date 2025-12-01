using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Infrastructure.Data;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.StudentManagement.Core.Services
{
    public class MajorService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public MajorService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Xem danh sách chuyên ngành
        public async Task<List<MajorReponseDTO>> GetAllAsync()
        {
            var majors = await _context.Majors.ToListAsync();
            return _mapper.Map<List<MajorReponseDTO>>(majors);
        }

        // Thêm chuyên ngành mới
        public async Task<MajorReponseDTO> CreateAsync(MajorRequestDTO dto)
        {
            var major = _mapper.Map<Major>(dto);
            _context.Majors.Add(major);
            await _context.SaveChangesAsync();
            return _mapper.Map<MajorReponseDTO>(major);
        }

        // Cập nhật chuyên ngành
        public async Task<MajorReponseDTO> UpdateAsync(int id, MajorRequestDTO dto)
        {
            var major = await _context.Majors.FindAsync(id);
            if (major == null) return null;

            _mapper.Map(dto, major);
            await _context.SaveChangesAsync();
            return _mapper.Map<MajorReponseDTO>(major);
        }

        // Xóa hoặc khóa chuyên ngành
        public async Task<bool> DeleteAsync(int id)
        {
            var major = await _context.Majors.FindAsync(id);
            if (major == null) return false;
            _context.Majors.Remove(major);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
