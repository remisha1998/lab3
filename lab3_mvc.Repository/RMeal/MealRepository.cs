using lab3_mvc.Repository.Domain;
namespace lab3_mvc.Repository.RMeal 
{ 
    public class MealRepository : GenericRepository<Meal>, IMealRepository 
    { 
        public MealRepository(RestaurantContext dbContext) 
        { 
            DbContext = dbContext; 
        } 
    } 
} 