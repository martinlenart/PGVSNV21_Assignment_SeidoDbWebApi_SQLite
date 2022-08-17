using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using SeidoDbWebApi.Logger;

namespace DbAppWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdController : ControllerBase
    {
        private ILogger<LogController> _logger;

        //GET /Log
        [HttpGet()]
        [ProducesResponseType(200, Type = typeof(string))]
        public string Get([FromServices] ILoggerProvider myLogger)
        {
            return AppConfig.ThisConnection;
        }
        public IdController(ILogger<LogController> logger)
        {
            _logger = logger;
            _logger.LogInformation($"IdController started: {AppConfig.ThisConnection}");
        }
    }
}
