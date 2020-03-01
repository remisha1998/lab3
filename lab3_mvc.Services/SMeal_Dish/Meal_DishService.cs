using lab3_mvc.Repository.Domain; 
using lab3_mvc.Repository.RMeal_Dish;
using lab3_mvc.Services.SMeal;

namespace lab3_mvc.Services.SMeal_Dish 
{ 
    public class Meal_DishService : GenericService<Meal_Dish>, IMeal_DishService 
    { 
        public Meal_DishService(IMeal_DishRepository meal_dishRepository) : base(meal_dishRepository) 
        {
        }
    }
} 