using lab3_mvc.Repository.Domain;
using lab3_mvc.Services.SMeal;
using lab3_mvc.Services.SMeal_Dish; 
using Microsoft.AspNetCore.Mvc;
namespace lab3_mvc.Api.Controller 
{ 
    [Route("api/meal_dish")] 
    public class Meal_dishController : ControllerBase 
    {
        private readonly IMeal_DishService _meal_dishService;
        public Meal_dishController(IMeal_DishService meal_dishService) 
        { 
            _meal_dishService = meal_dishService; 
        }
        [HttpGet] 
        [Route("{id}")] 
        public IActionResult Get([FromRoute] int id) 
            { 
                var meal_dish = _meal_dishService.GetById(id);
                
                if (meal_dish == null) 
                    return NotFound();
                
                return Ok(meal_dish);
            }
            [HttpGet] 
            [Route("")] 
            public IActionResult GetAll() 
            { 
                var meal_dishes = _meal_dishService.GetAll(); 
                return Ok(meal_dishes); 
            }
            [HttpPost] 
            [Route("")] 
            public IActionResult Post([FromBody] Meal_Dish model) 
            { 
                _meal_dishService.Insert(model);
            return Ok();
            }
            [HttpPut] 
            [Route("")] 
            public IActionResult Put([FromBody] Meal_Dish model) 
            { 
                _meal_dishService.Update(model); 
                return Ok(); 
            }
            [HttpDelete] 
            [Route("")] 
            public IActionResult Delete([FromBody] Meal_Dish model) 
            { 
                _meal_dishService.Delete(model); 
                return Ok(); 
            }
}
} 