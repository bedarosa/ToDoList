using AutoMapper;
using System;
using System.Linq;
using System.Reflection;
using ToDoList.Domain.Entidades;
using ToDoList.Service.ViewModels;

namespace ToDoList.Service.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var profiles = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(Profile).IsAssignableFrom(x));

            return new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(Activator.CreateInstance(profile) as Profile);
                }
            });
        }
    }

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Tarefa, TarefaViewModel>().ReverseMap();
        }
    }
}

