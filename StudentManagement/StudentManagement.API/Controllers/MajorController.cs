using Microsoft.AspNetCore.Mvc;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Services;

namespace StudentManagement.StudentManagement.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MajorController : ControllerBase
    {
        private readonly MajorService _service;

        public MajorController(MajorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<MajorReponseDTO>>> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult<MajorReponseDTO>> Create(MajorRequestDTO dto)
        {
            var major = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetAll), new { id = major.MajorId }, major);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MajorReponseDTO>> Update(int id, MajorRequestDTO dto)
        {
            var major = await _service.UpdateAsync(id, dto);
            if (major == null) return NotFound();
            return Ok(major);
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