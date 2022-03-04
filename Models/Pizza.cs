using AutoMapper;

namespace BarbosaPizza.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Taste { get; set; } = null!;
    }

    public class PizzaDto
    {
        public string Name { get; set; } = null!;
        public string Taste { get; set; } = null!;
    }

    public class PizzaProfile : Profile
    {
        public PizzaProfile()
        {
            CreateMap<Pizza, PizzaDto>().ReverseMap();
            //CreateMap<PizzaDto, Pizza>();
        }
    }
}