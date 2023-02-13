using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using Repository.Repositories;
using Server.Repository;
using Server.Repository.Entities;
using Services.Models;

namespace Services
{
    public static class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IPersonDal, PersonDal>();

            MapperConfiguration config = new MapperConfiguration(
               conf => conf.CreateMap<Person, PersonModel>()
               .ForMember(dest => dest.PersonId, opt => opt.MapFrom(dest => dest.PersonId))
               .ReverseMap()
               .ForMember(dest => dest.PersonId, opt => opt
               .MapFrom(dest => dest.PersonId)));
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddDbContext<IDataSource, Context>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
    }
}
