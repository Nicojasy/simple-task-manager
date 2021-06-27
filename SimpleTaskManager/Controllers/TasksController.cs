using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleTaskManager.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        private readonly ILogger<TasksController> _logger;

        public TasksController(ILogger<TasksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetTasks()
        {
            return Ok();
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetExpiring()
        {
            return Ok();
        }
    }
}
