using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world.Data.Models
{
    public class ComponentSeries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProducedFrom { get; set; }
        public DateTime? ProducedUntil { get; set; }

        //Navigation props
        //public int BrandId { get; set; }
        //public Brand Brand { get; set; }
        //public int AreaId { get; set; }
        //public Area Area { get; set; }
        public List<Component> Components { get; set; }
        //public List<ComponentSeriesPicture> ComponentSeriesPictures { get; set; }
    }
}
