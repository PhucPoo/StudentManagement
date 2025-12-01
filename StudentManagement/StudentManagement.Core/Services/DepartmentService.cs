using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Infrastructure.Data;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.StudentManagement.Core.Services
{
    public class DepartmentService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DepartmentService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Xem danh sách department
        public async Task<List<DepartmentReponseDTO>> GetAllAsync()
        {
            var departments = await _context.Departments.ToListAsync();
            return _mapper.Map<List<DepartmentReponseDTO>>(departments);
        }

        // Thêm department mới
        public async Task<DepartmentReponseDTO> CreateAsync(DepartmentRequestDTO dto)
        {
            var department = _mapper.Map<Department>(dto);
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return _mapper.Map<DepartmentReponseDTO>(department);
        }

        // Cập nhật department
        public async Task<DepartmentReponseDTO> UpdateAsync(int id, DepartmentRequestDTO dto)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null) return null;

            _mapper.Map(dto, department);
            await _context.SaveChangesAsync();
            return _mapper.Map<DepartmentReponseDTO>(department);
        }

        // Xóa hoặc khóa department
        public async Task<bool> DeleteAsync(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null) return false;
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

