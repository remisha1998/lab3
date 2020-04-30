using lab3_mvc.Repository.Domain; 
using lab3_mvc.Services.SMeal; 
using Microsoft.AspNetCore.Mvc;
namespace lab3_mvc.Api.Controller 
{ 
    [Route("api/meal")] 
    public class MealController : ControllerBase 
    {
        private readonly IMealService _mealService;
        public MealController(IMealService mealService) 
        { 
            _mealService = mealService; 
        }
        [HttpGet] 
        [Route("{id}")] 
        public IActionResult Get([FromRoute] int id) 
            { 
                var meal = _mealService.GetById(id);
                
                if (meal == null) 
                    return NotFound();
                
                return Ok(meal);
            }
            [HttpGet] 
            [Route("")] 
            public IActionResult GetAll() 
            { 
                var meals = _mealService.GetAll(); 
                return Ok(meals); 
            }
            [HttpPost] 
            [Route("")] 
            public IActionResult Post([FromBody] Meal model) 
            { 
                _mealService.Insert(model);
            return Ok();
            }
            [HttpPut] 
            [Route("")] 
            public IActionResult Put([FromBody] Meal model) 
            { 
                _mealService.Update(model); 
                return Ok(); 
            }
            [HttpDelete] 
            [Route("")] 
            public IActionResult Delete([FromBody] Meal model) 
            { 
                _mealService.Delete(model); 
                return Ok(); 
            }
}
} 