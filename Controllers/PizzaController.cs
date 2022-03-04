using Microsoft.AspNetCore.Mvc;
using BarbosaPizza.Models;
using BarbosaPizza.Interface;
namespace BarbosaPizza.Controllers
{
    [ApiController]
    [Route("pizza-controller")]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            this.pizzaService = pizzaService;
        }

        [HttpGet("pizzas")]
        public IActionResult GetAll()
        {
            return Ok(pizzaService.GetAll());
        }

        [HttpPost("pizzas")]
        public IActionResult Create(PizzaDto request)
        {
            var pizza = pizzaService.Create(request);
            return CreatedAtAction(nameof(GetAll), new { id = pizza.Id }, pizza);
            //return Ok(pizzaService.Create(pizza));

        }

    }
}