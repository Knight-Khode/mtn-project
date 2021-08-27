using AutoMapper;
using Church_Web.Db_Model;
using Church_Web.Models;
using static Church_Web.Models.UserViewModel;

namespace Church_Web.Implementation.Configurations
{
    public class MapperInitializer:Profile
    {
        public MapperInitializer()

        {
            CreateMap<User, RegisterUserDto>().ReverseMap();
            CreateMap<Church, ChurchMainPageViewModel>().ReverseMap();
            CreateMap<Event, ChurchMainPageViewModel>().ReverseMap();
        }
    }
}
