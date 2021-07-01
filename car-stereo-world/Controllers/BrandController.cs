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
    }
}
