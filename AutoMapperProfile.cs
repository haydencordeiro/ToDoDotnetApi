using AutoMapper;
using ToDoApi.Dtos;
using ToDoApi.Dtos.ToDo;
using ToDoApi.Models;

namespace ToDoApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<ToDo, GetToDoDto>();
            CreateMap<AddToDoDto, ToDo>();
        }

    }
}