using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleTaskManager.Data;
using System;
using System.Linq;

namespace SimpleTaskManager.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        private readonly TaskContext _context;
        private readonly ILogger<TasksController> _logger;

        public TasksController(ILogger<TasksController> logger, TaskContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetTasks()
            => Ok(_context.Tasks.ToList());

        [HttpGet]
        [Route("expiring")]
        public IActionResult GetExpiringTask()
        {
            DateTime now = DateTime.Now;
            return Ok(_context.Tasks.Where(t => now <= t.endDate && t.endDate <= now.AddHours(2)).ToList());
        }
    }
}
