using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world_api_demo.Data.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation props
        public List<ComponentSeries> ComponentSeries { get; set; }
        public List<Component> Components { get; set; }
    }
}
