using car_stereo_world.Data.Services;
using car_stereo_world.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentSeriesController : ControllerBase
    {
        private ComponentSeriesService _componentSeriesService;

        public ComponentSeriesController(ComponentSeriesService componentSeriesService)
        {
            _componentSeriesService = componentSeriesService;
        }

        [HttpPost("add-componentSeries")]
        public IActionResult AddComponentSeries([FromBody] ComponentSeriesVM componentSeries)
        {
            _componentSeriesService.AddComponentSeries(componentSeries);
            return Ok();
        }
    }
}
