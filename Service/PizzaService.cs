using BarbosaPizza.Models;
using BarbosaPizza.Interface;

using AutoMapper;
namespace BarbosaPizza.Service
{
    public class PizzaService : IPizzaService
    {
        private readonly IMapper mapper;

        public PizzaService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        static List<Pizza> Pizzas {get;set;} = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Barbosa Especial", Taste = "calabresa"},
            new Pizza { Id = 2, Name = "Barbosa Frango", Taste = "frango"},
            new Pizza { Id = 3, Name="Barbosa Plus", Taste = "Beringela"}
        };
        private int counter = 4; 

        public List<Pizza> GetAll()
        {
            return Pizzas;
        }

        public Pizza Create(PizzaDto request)
        {
            //var newPizza = new Pizza { Id = counter++, Name = request.Name, Taste = request.Taste };
            var newPizza = mapper.Map<Pizza>(request);
            newPizza.Id = counter++;
            Pizzas.Add(newPizza);
            return newPizza;
        }
    }
}