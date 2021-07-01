﻿using car_stereo_world.Data.Models;
using car_stereo_world.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world.Data.Services
{
    public class ComponentSeriesService
    {
        private AppDbContext _context;

        public ComponentSeriesService(AppDbContext context)
        {
            _context = context;
        }

        public void AddComponentSeries(ComponentSeriesVM componentSeries)
        {
            var _componentSeries = new ComponentSeries()
            {
                Name = componentSeries.Name,
                ProducedFrom = componentSeries.ProducedFrom,
                ProducedUntil = componentSeries.ProducedUntil,
                BrandId = componentSeries.BrandId
            };
            _context.ComponentSeries.Add(_componentSeries);
            _context.SaveChanges();
        }

        public ComponentSeriesWithComponentsVM GetComponentSeriesById(int componentSeriesId)
        {
            var _componentSeries = _context.ComponentSeries.Where(n => n.Id == componentSeriesId).Select(componentSeries => new ComponentSeriesWithComponentsVM()
            {
                Name = componentSeries.Name,
                BrandName = componentSeries.Brand.Name,
                ProducedFrom = componentSeries.ProducedFrom,
                ProducedUntil = componentSeries.ProducedUntil,
                Components = componentSeries.Components.Select(component => new ComponentVM()
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
                    Description = component.Description,
                    ComponentSeriesId = componentSeriesId
                }).ToList()
            }).FirstOrDefault();

            return _componentSeries;
        }
    }
}
