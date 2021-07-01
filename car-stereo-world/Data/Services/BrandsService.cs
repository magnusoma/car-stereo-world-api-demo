using car_stereo_world.Data.Models;
using car_stereo_world.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world.Data.Services
{
    public class BrandsService
    {
        private AppDbContext _context;

        public BrandsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBrand(BrandVM brand)
        {
            var _brand = new Brand()
            {
                Name = brand.Name
            };

            _context.Brands.Add(_brand);
            _context.SaveChanges();
        }
    }
}
