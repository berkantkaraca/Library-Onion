using AutoMapper;
using Library.Application.Mediator.Commands.AuthorCommands;
using Library.Application.Mediator.Results.AuthorResults.CommandResults;
using Library.Application.Mediator.Results.AuthorResults.QueryResults;
using Library.Domain.Entities;

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
        }
    }
}
