namespace OgrenciOtomasyonSistemi.api.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using OgrenciOtomasyonSistemi.api.Data;
    using OgrenciOtomasyonSistemi.api.DTOs;
    using OgrenciOtomasyonSistemi.api.Entities;
    using static OgrenciOtomasyonSistemi.api.Data.AppDbContext;

    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TeacherController(ApplicationDbContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetTeachers() => Ok(await _context.Teachers.ToListAsync());

        [HttpPost]
        public async Task<IActionResult> CreateTeacher([FromBody] CreateTeacherDto dto)
        {
            var teacher = new Teacher { firstName = dto.firstName, lastName = dto.lastName };
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTeacherById), new { id = teacher.id }, teacher);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeacherById(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null) return NotFound();
            return Ok(teacher);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeacher(int id, [FromBody] UpdateTeacherDto dto)
        {
            var teacherInDb = await _context.Teachers.FindAsync(id);
            if (teacherInDb == null) return NotFound();

            teacherInDb.firstName = dto.firstName;
            teacherInDb.lastName = dto.lastName;

            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
