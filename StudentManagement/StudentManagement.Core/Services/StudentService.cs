using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Infrastructure.Data;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.StudentManagement.Core.Services
{
    public class StudentService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public StudentService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Xem danh sách sinh viên
        public async Task<List<StudentReponseDTO>> GetAllAsync()
        {
            var students = await _context.Students.ToListAsync();
            return _mapper.Map<List<StudentReponseDTO>>(students);
        }

        // Thêm sinh viên mới
        public async Task<StudentReponseDTO> CreateAsync(StudentRequestDTO dto)
        {
            var student = _mapper.Map<Student>(dto);
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return _mapper.Map<StudentReponseDTO>(student);
        }

        // Cập nhật sinh viên
        public async Task<StudentReponseDTO> UpdateAsync(int id, StudentRequestDTO dto)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return null;

            _mapper.Map(dto, student);
            await _context.SaveChangesAsync();
            return _mapper.Map<StudentReponseDTO>(student);
        }

        // Xóa hoặc khóa sinh viên
        public async Task<bool> DeleteAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return false;

            // Thay vì xóa thật, đánh dấu "tạm ngưng"
            student.Status = "Inactive";
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
