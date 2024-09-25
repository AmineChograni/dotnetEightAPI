using dotnetEightAPI.Data;
using Microsoft.AspNetCore.Mvc;

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


    }
}
