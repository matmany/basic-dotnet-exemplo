using BarbosaPizza.Models;

namespace BarbosaPizza.Interface
{
    public interface IPizzaService
    {
        List<Pizza> GetAll();

        Pizza Create(PizzaDto pizza);
    }
}