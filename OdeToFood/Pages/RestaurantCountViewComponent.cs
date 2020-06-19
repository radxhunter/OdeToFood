using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;

namespace OdeToFood.Pages
{
    public class RestaurantCountViewComponent : ViewComponent
    {
        private readonly IRestaurantData restaurantData;

        public RestaurantCountViewComponent(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public IViewComponentResult Invoke()
        {
            var count = restaurantData.GetCountOfRestaurant();
            return View(count);
        }
    }
}