using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWebApi.Profiles
{
    public class TodoProfile : Profile
    {

        public TodoProfile()
        {
            CreateMap<Entities.Todo, Models.TodoDto>();

            CreateMap<Models.TodoForUpdatimgDto, Entities.Todo>().ReverseMap();
            //CreateMap<Entities.PointOfInterest, Models.PointOfInterestForUpdatingDto>();
        }
    }
}
