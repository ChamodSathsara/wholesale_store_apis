using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace wholesale_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase

    {
        [HttpGet]
        public IActionResult getTasks() 
        {
            return Ok(new List<Task>());
        }



    }
}
