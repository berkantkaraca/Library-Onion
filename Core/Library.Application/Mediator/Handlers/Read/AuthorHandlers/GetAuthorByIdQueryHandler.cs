using AutoMapper;
using Library.Application.Mediator.Queries.AuthorQueries;
using Library.Application.Mediator.Results.AuthorResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Read.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public GetAuthorByIdQueryHandler(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            Author author = await _repository.GetByIdAsync(request.Id);

            if (author == null)
                return null;

            return _mapper.Map<GetAuthorByIdQueryResult>(author);
        }
    }
}
