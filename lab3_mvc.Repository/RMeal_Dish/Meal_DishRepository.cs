using lab3_mvc.Repository.Domain;
namespace lab3_mvc.Repository.RMeal_Dish 
{ 
    public class Meal_DishRepository : GenericRepository<Meal_Dish>, IMeal_DishRepository 
    { 
        public Meal_DishRepository(RestaurantContext dbContext) 
        { 
            DbContext = dbContext; 
        } 
    } 
} 