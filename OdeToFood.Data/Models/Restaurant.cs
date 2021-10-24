using System;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CuisineType Cuising { get; set; }
    }
}
