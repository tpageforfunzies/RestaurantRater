using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        //Properties
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }

    //DbContext handles relationship to the DB, includes querying
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}