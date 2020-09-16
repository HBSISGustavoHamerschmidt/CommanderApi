using Commander.Dtos;
using Commander.Models;

namespace Commander.Profile
{
    public class CommandsProfile : AutoMapper.Profile
    {
        public CommandsProfile() => CreateMap<Command, CommandReadDto>();
    }
}