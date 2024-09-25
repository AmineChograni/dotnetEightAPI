using dotnetEightAPI.Data;
using dotnetEightAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetEightAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// api/students
    public class StudentsController:ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            var students = await _context.Students.AsNoTracking().ToListAsync();

            return students;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.AddAsync(student);

            var result = await _context.SaveChangesAsync();

            if (result > 0)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
