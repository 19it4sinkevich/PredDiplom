using AutoMapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Entities.DataTransferObjects;
using Entities.Models;
namespace PredDiplom
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookForCreationDto, Book>();
            CreateMap<BookForUpdateDto, Book>();
            CreateMap<BookForUpdateDto, Book>().ReverseMap();

        }
    }

}
