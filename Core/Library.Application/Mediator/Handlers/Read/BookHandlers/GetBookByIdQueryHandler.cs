using AutoMapper;
using Library.Application.Mediator.Queries.BookQueries;
using Library.Application.Mediator.Results.BookResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Read.BookHandlers
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, GetBookByIdQueryResult>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public GetBookByIdQueryHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBookByIdQueryResult> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            Book book = await _repository.GetByIdAsync(request.Id);

            return _mapper.Map<GetBookByIdQueryResult>(book);
        }
    }
}
