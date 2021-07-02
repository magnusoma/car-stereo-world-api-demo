using car_stereo_world_api_demo.Data.Models;
using car_stereo_world_api_demo.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world_api_demo.Data.Services
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


        public BrandWithComponentsVM GetBrandWithComponents(int brandId)
        {
            var _brand = _context.Brands.Where(n => n.Id == brandId).Select(brand => new BrandWithComponentsVM()
            {
                Name = brand.Name,

                //Creating list with components
                //Ikke opptimalt, burde hatt fk til brand i component tabellen
                Components = brand.Components.Select(component => new ComponentWithBrandAndComponentSeriesVM()
                {
                    Name = component.Name,
                    BrandName = brand.Name,
                    Model = component.Model,
                    AvailableFrom = component.AvailableFrom,
                    AvailableUntil = component.AvailableUntil,
                    PriceNew = component.PriceNew,
                    Value100 = component.Value100,
                    Value80 = component.Value80,
                    Value60 = component.Value60,
                    Value40 = component.Value40,
                    Value20 = component.Value20,
                    Description = component.Description,
                    ComponentSeries = component.ComponentSeries.Name
                }).ToList()
            }).FirstOrDefault();

            return _brand;
        }
        public BrandWithComponentSeriesVM GetBrandWithComponentSeries(int brandId)
        {
            var _brand = _context.Brands.Where(n => n.Id == brandId).Select(brand => new BrandWithComponentSeriesVM()
            {
                Name = brand.Name,

                //Creating list with component series
                ComponentSeries = brand.ComponentSeries.Select(componentSeries => new ComponentSeriesWithComponentsVM()
                {
                    Name = componentSeries.Name,
                    ProducedFrom = componentSeries.ProducedFrom,
                    ProducedUntil = componentSeries.ProducedUntil,

                    //Creating list with components
                    Components = componentSeries.Components.Select(component => new ComponentWithoutFKsVM()
                    {
                        Name = component.Name,
                        Model = component.Model,
                        AvailableFrom = component.AvailableFrom,
                        AvailableUntil = component.AvailableUntil,
                        PriceNew = component.PriceNew,
                        Value100 = component.Value100,
                        Value80 = component.Value80,
                        Value60 = component.Value60,
                        Value40 = component.Value40,
                        Value20 = component.Value20,
                        Description = component.Description
                    }).ToList()
                }).ToList()
            }).FirstOrDefault();

            return _brand;
        }
    }
}
