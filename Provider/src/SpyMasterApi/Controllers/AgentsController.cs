namespace SpyMasterApi.Controllers
{
    using System;
    using System.Net;
    using Microsoft.AspNetCore.Mvc;
    using Services;

    [Route("[controller]")]
    [ApiController]
    public class AgentsController : ControllerBase
    {
        private readonly IAgentsService _agentService;

        public AgentsController(IAgentsService agentService)
        {
            _agentService = agentService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
           throw new NotImplementedException("TODO: Return the spy details!");
        }
    }
}
