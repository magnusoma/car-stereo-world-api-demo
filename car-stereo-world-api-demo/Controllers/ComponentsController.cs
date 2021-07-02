using car_stereo_world_api_demo.Data.Services;
using car_stereo_world_api_demo.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world_api_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentsController : ControllerBase
    {
        public ComponentsService _componentsService;

        public ComponentsController(ComponentsService componentsService)
        {
            _componentsService = componentsService;
        }

        [HttpGet("get-all-components")]
        public IActionResult GetAllComponents()
        {
            var allComponents = _componentsService.GetAllComponents();
            return Ok(allComponents);
        }

        [HttpGet("get-component-by-id/{id}")]
        public IActionResult GetComponentById(int id)
        {
            var component = _componentsService.GetComponentById(id);
            return Ok(component);
        }

        [HttpPost("add-component")]
        public IActionResult AddComponent([FromBody]ComponentVM component)
        {
            _componentsService.AddComponent(component);
            return Ok();
        }

        [HttpPut("update-book-by-id/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody] ComponentVM component)
        {
            var updatedComponent = _componentsService.UpdateComponentById(id, component);
            return Ok(updatedComponent);
        }

        [HttpDelete("delete-component-by-id/{id}")]
        public IActionResult DeleteComponentById(int id)
        {
            var deletedComponent = _componentsService.DeleteComponentById(id);
            return Ok(deletedComponent);
        }
    }
}
