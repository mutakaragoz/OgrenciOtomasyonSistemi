namespace OgrenciOtomasyonSistemi.api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using OgrenciOtomasyonSistemi.Shared.DTOs;
    using OgrenciOtomasyonSistemi.api.Entities;
    using static OgrenciOtomasyonSistemi.api.Data.AppDbContext;
    using Microsoft.AspNetCore.Authorization;

    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context) => _context = context;

        [HttpGet]
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> GetAllStudents() => Ok(await _context.Students.ToListAsync());

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Teacher,Student")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return NotFound();
            return Ok(student);
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentDto dto)
        {
            var student = new Student
            {
                firstName = dto.firstName,
                lastName = dto.lastName,
                number = dto.number
            };
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetStudentById), new { id = student.id }, student);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] UpdateStudentDto dto)
        {
            var studentInDb = await _context.Students.FindAsync(id);
            if (studentInDb == null)
            {
                return NotFound();
            }
            studentInDb.firstName = dto.firstName;
            studentInDb.lastName = dto.lastName;

            await _context.SaveChangesAsync();
            return NoContent(); 
        }
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var studentInDb = await _context.Students.FindAsync(id);
            if (studentInDb == null)
            {
                return NotFound();
            }

            _context.Students.Remove(studentInDb);
            await _context.SaveChangesAsync();
            return NoContent(); 
        }
    }
}
