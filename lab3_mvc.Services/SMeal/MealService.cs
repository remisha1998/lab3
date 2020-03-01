using lab3_mvc.Repository.Domain; 
using lab3_mvc.Repository.RMeal;
namespace lab3_mvc.Services.SMeal 
{ 
    public class MealService : GenericService<Meal>, IMealService 
    { 
        public MealService(IMealRepository mealRepository) : base(mealRepository) 
        {
        }
    }
} 