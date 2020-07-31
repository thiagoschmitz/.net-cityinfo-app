﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController] // Improve things like errors and development in general
    [Route("api/[controller]")] //-> Uses the name of the controller
    public class CitiesController: ControllerBase
    {
        [HttpGet] //("api/cities")
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1, Name = "Dublin" },
                    new { id = 2, Name = "Swords" }
                });
        }
    }
}