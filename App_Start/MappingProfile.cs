using AutoMapper;
using MovieRental.Dtos;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.App_Start
{
    public class MappingProfile: Profile
    {

        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<MembershipType, MembershipTypeDto>();
            CreateMap<Genre, GenreDto>();

            CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore()); //"Hey, don't worry about the id, don't map that." 
        }
    }
}