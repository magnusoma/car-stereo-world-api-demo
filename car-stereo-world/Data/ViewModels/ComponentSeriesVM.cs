﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world.Data.ViewModels
{
    public class ComponentSeriesVM
    {
        public string Name { get; set; }
        public DateTime ProducedFrom { get; set; }
        public DateTime? ProducedUntil { get; set; }
    }

    public class ComponentSeriesWithComponentsVM
    {
        public string Name { get; set; }
        public DateTime ProducedFrom { get; set; }
        public DateTime? ProducedUntil { get; set; }
        public List<ComponentVM> Components { get; set; }
    }
}