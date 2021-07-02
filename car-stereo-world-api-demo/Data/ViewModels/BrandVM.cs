using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world_api_demo.Data.ViewModels
{
    public class BrandVM
    {
        public string Name { get; set; }
    }

    public class BrandWithComponentsVM
    {
        public string Name { get; set; }
        public List<ComponentWithBrandAndComponentSeriesVM> Components { get; set; }
    }

    public class BrandWithComponentSeriesVM
    {
        public string Name { get; set; }
        public List<ComponentSeriesWithComponentsVM> ComponentSeries { get; set; }
    }
}
