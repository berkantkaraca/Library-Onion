using AutoMapper;
using Library.Application.Mediator.Commands.AuthorCommands;
using Library.Application.Mediator.Results.AuthorResults.CommandResults;
using Library.Application.Mediator.Results.AuthorResults.QueryResults;
using Library.Domain.Entities;
using Library.Application.Mediator.Commands.BookCommands;
using Library.Application.Mediator.Results.BookResults.CommandResults;
using Library.Application.Mediator.Results.BookResults.QueryResults;
using Library.Application.Mediator.Commands.TagCommands;
using Library.Application.Mediator.Results.TagResults.CommandResults;
using Library.Application.Mediator.Results.TagResults.QueryResults;
using Library.Application.Mediator.Commands.CategoryCommands;
using Library.Application.Mediator.Results.CategoryResults.CommandResults;
using Library.Application.Mediator.Results.CategoryResults.QueryResults;
using Library.Application.Mediator.Commands.BookTagCommands;
using Library.Application.Mediator.Results.BookTagResults.CommandResults;
using Library.Application.Mediator.Results.BookTagResults.QueryResults;

namespace Library.Application.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Author
            CreateMap<CreateAuthorCommand, Author>();
            CreateMap<UpdateAuthorCommand, Author>();
            CreateMap<Author, GetAuthorCommandResult>();
            CreateMap<Author, GetAuthorQueryResult>();
            CreateMap<Author, GetAuthorByIdQueryResult>();

            //Book
            CreateMap<CreateBookCommand, Book>();
            CreateMap<UpdateBookCommand, Book>();
            CreateMap<Book, GetBookCommandResult>();
            CreateMap<Book, GetBookQueryResult>();

            //Tag
            CreateMap<CreateTagCommand, Tag>();
            CreateMap<UpdateTagCommand, Tag>();
            CreateMap<Tag, GetTagCommandResult>();
            CreateMap<Tag, GetTagQueryResult>();

            //Category
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();
            CreateMap<Category, GetCategoryCommandResult>();
            CreateMap<Category, GetCategoryQueryResult>();

            //BookTag
            CreateMap<CreateBookTagCommand, BookTag>();
            CreateMap<UpdateBookTagCommand, BookTag>();
            CreateMap<BookTag, GetBookTagCommandResult>();
            CreateMap<BookTag, GetBookTagQueryResult>();
        }
    }
}
