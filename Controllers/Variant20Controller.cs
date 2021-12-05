using MDTA_Labs.Model.Variant_20;
using MDTA_Labs.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MDTA_Labs.Controllers
{
    [ApiController]
    [Route("api/v1/variant20")]
    public class Variant20Controller : Controller
    {
        private readonly ILogger<Variant20Controller> _logger;
        private readonly Variant20Calculator _bestOptionsCalculator;

        public Variant20Controller(ILogger<Variant20Controller> logger)
        {
            _logger = logger;
            _bestOptionsCalculator = new Variant20Calculator();
        }

        [HttpGet("calculateBestOptions")]
        public async Task<IActionResult> CalculateBestOptions([FromQuery] List<ShipProperties> properties)
        {
            var cumulativeProperty = ShipProperties.None;

            foreach (var property in properties)
            {
                if (!Enum.IsDefined(typeof(ShipProperties), property))
                {
                    return BadRequest($"Property {property} is not defined");
                }

                cumulativeProperty = cumulativeProperty | property;
            }

            return Json(_bestOptionsCalculator.CalculateBestOption(cumulativeProperty));
        }

        [HttpGet("getProperties")]
        public async Task<IActionResult> GetProperties()
        {
            return Json(_bestOptionsCalculator.GetAllProperties());
        }
    }
}
