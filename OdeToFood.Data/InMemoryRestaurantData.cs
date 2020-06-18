using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "Scott's Pizza", Location = "Rybnik", Cuisine = CuisineType.None},
                new Restaurant {Id = 2, Name = "Sappori Dela Vita", Location = "Rybnik", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 3, Name = "Sake", Location = "Rybnik", Cuisine = CuisineType.Indian},
                new Restaurant {Id = 4, Name = "BullDog", Location = "Żory", Cuisine = CuisineType.Mexican}
            };
        }

        public Restaurant Update(Restaurant updateRestaurant)
        {
            var restaurant = _restaurants.SingleOrDefault(r => r.Id == updateRestaurant.Id);
            if (restaurant != null)
            {
                restaurant.Name = updateRestaurant.Name;
                restaurant.Location = updateRestaurant.Location;
                restaurant.Cuisine = updateRestaurant.Cuisine;
            }

            return restaurant;
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            _restaurants.Add(newRestaurant);
            newRestaurant.Id = _restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }

        public int Commit()
        {
            return 0;
        }

        public Restaurant GetById(int id)
        {
            return _restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in _restaurants
                where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                orderby r.Name
                select r;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = _restaurants.FirstOrDefault(r => r.Id == id);
            if (restaurant != null)
                _restaurants.Remove(restaurant);
            return restaurant;
        }

        public int GetCountOfRestaurant()
        {
            return _restaurants.Count();
        }
    }
}