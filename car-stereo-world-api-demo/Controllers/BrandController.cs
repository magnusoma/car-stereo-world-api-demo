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
    public class BrandController : ControllerBase
    {
        private BrandsService _brandsService;

        public BrandController(BrandsService brandsService)
        {
            _brandsService = brandsService;
        }

        [HttpPost("add-brand")]
        public IActionResult AddBrand([FromBody] BrandVM brand)
        {
            _brandsService.AddBrand(brand);
            return Ok();
        }

        [HttpGet("get-brand-list")]
        public IActionResult GetBrandList()
        {
            var brandList = _brandsService.GetBrandList();
            return Ok(brandList);
        }

        [HttpGet("get-brand-with-components/{id}")]
        public IActionResult GetBrandWithComponents(int id)
        {
            var brandWithComponents = _brandsService.GetBrandWithComponents(id);
            return Ok(brandWithComponents);
        }


        [HttpGet("get-brand-with-component-series/{id}")]
        public IActionResult GetBrandWithComponentSeries(int id)
        {
            var brandWithComponentSeries = _brandsService.GetBrandWithComponentSeries(id);
            return Ok(brandWithComponentSeries);
        }

        [HttpGet("get-brand-with-component-series-list/{id}")]
        public IActionResult GetBrandWithComponentSeriesList(int id)
        {
            var brandWithComponentSeriesList = _brandsService.GetBrandWithComponentSeriesList(id);
            return Ok(brandWithComponentSeriesList);
        }
    }
}
