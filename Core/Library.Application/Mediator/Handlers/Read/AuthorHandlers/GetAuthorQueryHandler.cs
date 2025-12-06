using AutoMapper;
using Library.Application.Mediator.Queries.AuthorQueries;
using Library.Application.Mediator.Results.AuthorResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Read.AuthorHandlers
{
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public GetAuthorQueryHandler(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            List<Author> authors = await _repository.GetAllAsync();

            return _mapper.Map<List<GetAuthorQueryResult>>(authors);
        }
    }
}
