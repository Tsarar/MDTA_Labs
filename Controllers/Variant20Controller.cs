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

        [HttpGet("getTask3Diagram")]
        public IActionResult GetTask3Diagram()
        {
            var path = "variant20_0.png";
            var image = System.IO.File.ReadAllBytes("Images/" + path);   // You can use your own method over here.         
            return File(image, "image/png");
        }

        [HttpGet("getTask3DiagramByOption")]
        public IActionResult GetTask3DiagramByOption([FromQuery] List<ShipProperties> properties)
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

            var type = _bestOptionsCalculator.GetTask3TypeByProps(cumulativeProperty);

            var path = _bestOptionsCalculator.GetTask3SchemeByType(type);

            if (path == null)
            {
                return NotFound();
            }

            var image = System.IO.File.ReadAllBytes("Images/" + path);   // You can use your own method over here.         
            return File(image, "image/png");
        }

        [HttpGet("getTask3DiagramNames")]
        public IActionResult GetTask3DiagramNames([FromQuery] List<ShipProperties> properties)
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

            return Json(_bestOptionsCalculator.GetTask3DiagramNames(cumulativeProperty));
        }

        [HttpGet("getTask3DiagramExactOption")]
        public IActionResult GetTask3DiagramExactOption([FromQuery] int option)
        {
            var path = _bestOptionsCalculator.GetTask3SchemeByOption(option);

            if (path == null)
            {
                return NotFound();
            }

            var image = System.IO.File.ReadAllBytes("Images/" + path);   // You can use your own method over here.         
            return File(image, "image/png");
        }

        [HttpGet("getTask3DiagramLog")]
        public IActionResult GetTask3DiagramLog([FromQuery] int option)
        {
            return Json(_bestOptionsCalculator.GetTask3LogByOption(option));
        }
    }
}
