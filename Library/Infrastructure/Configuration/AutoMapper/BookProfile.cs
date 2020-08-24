using AutoMapper;
using Library.Models;
using Library.Models.Books;

namespace Library.Infrastructure.Configuration.AutoMapper
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<AddBookModel, BookModel>();
        }
    }
}