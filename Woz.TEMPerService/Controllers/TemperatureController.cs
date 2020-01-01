using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Woz.TEMPer;
using Woz.TEMPerService.Models;

namespace Woz.TEMPerService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly ILogger<TemperatureController> _logger;
        private readonly TEMPerSensors _sensors;

        public TemperatureController(
            ILogger<TemperatureController> logger, TEMPerSensors sensors)
        {
            _logger = logger;
            _sensors = sensors;
        }

        [HttpGet]
        public IEnumerable<TemperatureReading> Get() 
            => _sensors.ReadTemperatures().Result.Select(TemperatureReading.Create).ToArray();

    }
}
