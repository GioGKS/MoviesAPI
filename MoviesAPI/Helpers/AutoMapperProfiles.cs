using System;
using AutoMapper;
using MoviesAPI.DTO;
using MoviesAPI.Entities;

namespace MoviesAPI.Helpers
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<GenreDTO, Genre>().ReverseMap();
			CreateMap<GenreCreationDTO, Genre>();
		}
	}
}

