using Microsoft.AspNetCore.Mvc;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Services;

namespace StudentManagement.StudentManagement.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _service;

        public UsersController(UserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserReponseDTO>>> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult<UserReponseDTO>> Create(UserRequestDTO dto)
        {
            var user = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetAll), new { id = user.UserId }, user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserReponseDTO>> Update(int id, UserRequestDTO dto)
        {
            var user = await _service.UpdateAsync(id, dto);
            if (user == null) return NotFound();
            return Ok(user);
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
