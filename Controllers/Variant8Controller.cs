using MDTA_Labs.Model.Variant_8;
using MDTA_Labs.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MDTA_Labs.Controllers
{
    [ApiController]
    [Route("api/v1/variant8")]
    public class Variant8Controller : Controller
    {
        private readonly ILogger<Variant8Controller> _logger;
        private readonly Variant8Calculator _bestOptionsCalculator;

        public Variant8Controller(ILogger<Variant8Controller> logger)
        {
            _logger = logger;
            _bestOptionsCalculator = new Variant8Calculator();
        }

        [HttpGet("calculateBestOptions")]
        public async Task<IActionResult> CalculateBestOptions([FromQuery] List<CommunicationProperties> properties)
        {
            var cumulativeProperty = CommunicationProperties.None;

            foreach (var property in properties)
            {
                if (!Enum.IsDefined(typeof(CommunicationProperties), property))
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

        [HttpGet("getTypes")]
        public async Task<IActionResult> GetTypes()
        {
            return Json(_bestOptionsCalculator.GetAllTypes());
        }

        [HttpGet("getDiagram")]
        public IActionResult GetDiagram([FromQuery] int type)
        {
            var path = _bestOptionsCalculator.GetSchemeByType(type);
            var image = System.IO.File.ReadAllBytes("Images/" + path);   // You can use your own method over here.         
            return File(image, "image/png");
        }
    }
}
