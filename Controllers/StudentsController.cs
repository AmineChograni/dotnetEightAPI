using Microsoft.AspNetCore.Mvc;

namespace dotnetEightAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// api/students
    public class StudentsController:ControllerBase
    {
        [HttpGet]
        public string SayHi()
        {
            return "Hi";
        }
    }
}
