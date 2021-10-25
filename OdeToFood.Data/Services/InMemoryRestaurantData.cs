using System.Collections.Generic;
using System.Linq;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> Restaurants;

        public InMemoryRestaurantData()
        {
            this.Restaurants = new List<Restaurant>()
            {
                new Restaurant{ID = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant{ID = 2, Name = "Tersiguels", Cuisine = CuisineType.French},
                new Restaurant{ID = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return this.Restaurants.OrderBy(r => r.Name);
        }
    }
}
