using car_stereo_world_api_demo.Data.Models;
using car_stereo_world_api_demo.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world_api_demo.Data.Services
{
    public class ComponentsService
    {
        private AppDbContext _context;

        public ComponentsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddComponent(ComponentVM component)
        {
            var _component = new Component()
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
                BrandId = component.BrandId,
                ComponentSeriesId = component.ComponentSeriesId != null ? component.ComponentSeriesId : null

            };

            _context.Components.Add(_component);
            _context.SaveChanges();
        }

        public List<ComponentWithBrandAndComponentSeriesVM> GetAllComponents() => 
            _context.Components.Select(component => new ComponentWithBrandAndComponentSeriesVM()
        {
            Id = component.Id,
            Name = component.Name,
            BrandName = component.Brand.Name,
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
        }).ToList();

        public ComponentWithBrandAndComponentSeriesVM GetComponentById(int componentId)
        {
            var _component = _context.Components.Where(n => n.Id == componentId).Select(component => new ComponentWithBrandAndComponentSeriesVM()
            {
                Id = component.Id,
                Name = component.Name,
                BrandName = component.Brand.Name,
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
            }).FirstOrDefault();

            return _component;
        }

        public Component UpdateComponentById(int componentId, ComponentVM component)
        {
            var _component = _context.Components.FirstOrDefault(n => n.Id == componentId);
            if (_component != null)
            {
                _component.Name = component.Name;
                _component.Model = component.Model;
                _component.AvailableFrom = component.AvailableFrom;
                _component.AvailableUntil = component.AvailableUntil;
                _component.PriceNew = component.PriceNew;
                _component.Value100 = component.Value100;
                _component.Value80 = component.Value80;
                _component.Value60 = component.Value60;
                _component.Value40 = component.Value40;
                _component.Value20 = component.Value20;
                _component.Description = component.Description;
                _component.BrandId = component.BrandId;
                _component.ComponentSeriesId = component.ComponentSeriesId != null ? component.ComponentSeriesId : null;

                _context.SaveChanges();
            }

            return _component;
        }

        public Component DeleteComponentById(int componentId)
        {
            var _component = _context.Components.FirstOrDefault(n => n.Id == componentId);

            if (_component != null)
            {
                _context.Components.Remove(_component);
                _context.SaveChanges();
            }

            return _component;
        }
    }
}
