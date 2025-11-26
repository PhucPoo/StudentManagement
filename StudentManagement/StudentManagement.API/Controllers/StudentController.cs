using Microsoft.AspNetCore.Mvc;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Services;

namespace StudentManagement.StudentManagement.API.Controllers
{
   
        [ApiController]
        [Route("api/[controller]")]
        public class StudentsController : ControllerBase
        {
            private readonly StudentService _service;

            public StudentsController(StudentService service)
            {
                _service = service;
            }

            [HttpGet]
            public async Task<ActionResult<List<StudentReponseDTO>>> GetAll()
            {
                return Ok(await _service.GetAllAsync());
            }

            [HttpPost]
            public async Task<ActionResult<StudentReponseDTO>> Create(StudentRequestDTO dto)
            {
                var student = await _service.CreateAsync(dto);
                return CreatedAtAction(nameof(GetAll), new { id = student.StudentId }, student);
            }

            [HttpPut("{id}")]
            public async Task<ActionResult<StudentReponseDTO>> Update(int id, StudentRequestDTO dto)
            {
                var student = await _service.UpdateAsync(id, dto);
                if (student == null) return NotFound();
                return Ok(student);
            }

            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(int id)
            {
                var success = await _service.DeleteAsync(id);
                if (!success) return NotFound();
                return NoContent();
            }
        }

    
}
