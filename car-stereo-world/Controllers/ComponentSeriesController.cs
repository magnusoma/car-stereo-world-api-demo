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

        [HttpGet("get-component-series-by-id/{id}")]
        public IActionResult GetComponentSeriesById(int id)
        {
            var ComponentSeries = _componentSeriesService.GetComponentSeriesById(id);
            return Ok(ComponentSeries);
        }

        [HttpPost("add-componentSeries")]
        public IActionResult AddComponentSeries([FromBody] ComponentSeriesVM componentSeries)
        {
            _componentSeriesService.AddComponentSeries(componentSeries);
            return Ok();
        }
    }
}
