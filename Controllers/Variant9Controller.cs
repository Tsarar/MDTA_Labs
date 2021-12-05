﻿using MDTA_Labs.Model.Variant_9;
using MDTA_Labs.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MDTA_Labs.Controllers
{
    [ApiController]
    [Route("api/v1/variant9")]
    public class Variant9Controller : Controller
    {
        private readonly ILogger<Variant9Controller> _logger;
        private readonly Variant9Calculator _bestOptionsCalculator;

        public Variant9Controller(ILogger<Variant9Controller> logger)
        {
            _logger = logger;
            _bestOptionsCalculator = new Variant9Calculator();
        }

        [HttpGet("calculateBestOptions")]
        public async Task<IActionResult> CalculateBestOptions([FromQuery] List<MechanicalIssue> properties)
        {
            var cumulativeProperty = MechanicalIssue.None;

            foreach (var property in properties)
            {
                if (!Enum.IsDefined(typeof(MechanicalIssue), property))
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