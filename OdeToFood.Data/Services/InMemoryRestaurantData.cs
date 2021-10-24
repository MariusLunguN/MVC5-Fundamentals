using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> Restaurants;

        public InMemoryRestaurantData()
        {
            this.Restaurants = new List<Restaurant>()
            {
                new Restaurant{ID = 1, Name = "Scott's Pizza", Cuising = CuisineType.Italian},
                new Restaurant{ID = 2, Name = "Tersiguels", Cuising = CuisineType.French},
                new Restaurant{ID = 3, Name = "Mango Grove", Cuising = CuisineType.Indian }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return this.Restaurants.OrderBy(r => r.Name);
        }
    }
}
