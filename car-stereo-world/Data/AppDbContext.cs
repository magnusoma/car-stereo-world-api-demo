using car_stereo_world.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_stereo_world.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        /*public DbSet<Area> Areas { get; set; }
        public DbSet<Brand> Brands { get; set; }*/
        public DbSet<Component> Components { get; set; }
        public DbSet<ComponentSeries> ComponentSeries { get; set; }        
        /*public DbSet<ComponentPicture> ComponentPictures { get; set; }
        public DbSet<ComponentSeriesPicture> ComponentSeriesPictures { get; set; }*/
    }
}
