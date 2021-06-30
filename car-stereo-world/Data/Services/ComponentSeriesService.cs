using car_stereo_world.Data.Models;
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
                ProducedUntil = componentSeries.ProducedUntil
            };
            _context.ComponentSeries.Add(_componentSeries);
            _context.SaveChanges();
        }
    }
}
