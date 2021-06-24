using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Qrcode.Flow.Model.Entities;
using Qrcode.Flow.Service.Interface;

namespace Qrcode.Flow.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {

        private readonly ILogger<TaskController> _logger;
        private readonly IFlowTaskService _flowTaskService;

        public TaskController(ILogger<TaskController> logger, IFlowTaskService flowTaskService)
        {
            _logger = logger;
            _flowTaskService = flowTaskService;
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Create(FlowTask task)
        {
            _flowTaskService.Create(task);
            return Ok();
        }
    }
}
