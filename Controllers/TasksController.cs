using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wholesale_store.Servicess.Repositories;

namespace wholesale_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        public readonly ITasksRepository _service;

        public TasksController(ITasksRepository service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult getTasks() 
        {
            //Console.Write(_service.AllTasks);
            return Ok(_service.AllTasks());
        }



    }
}
