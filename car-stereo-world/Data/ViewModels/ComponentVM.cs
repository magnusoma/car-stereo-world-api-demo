using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world.Data.ViewModels
{
    public class ComponentVM
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime? AvailableUntil { get; set; }
        public double PriceNew { get; set; }
        public double Value100 { get; set; }
        public double Value80 { get; set; }
        public double Value60 { get; set; }
        public double Value40 { get; set; }
        public double Value20 { get; set; }
        public string Description { get; set; }
        public int ComponentSeriesId { get; set; }
    }

    public class ComponentWithoutComponentSeriesIdVM
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime? AvailableUntil { get; set; }
        public double PriceNew { get; set; }
        public double Value100 { get; set; }
        public double Value80 { get; set; }
        public double Value60 { get; set; }
        public double Value40 { get; set; }
        public double Value20 { get; set; }
        public string Description { get; set; }
    }

    public class ComponentWithComponentSeriesVM
    {
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime? AvailableUntil { get; set; }
        public double PriceNew { get; set; }
        public double Value100 { get; set; }
        public double Value80 { get; set; }
        public double Value60 { get; set; }
        public double Value40 { get; set; }
        public double Value20 { get; set; }
        public string Description { get; set; }
        public string ComponentSeries { get; set; }
    }
}
