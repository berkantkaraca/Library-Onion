using AutoMapper;
using Library.Application.Mediator.Queries.BookQueries;
using Library.Application.Mediator.Results.BookResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Read.BookHandlers
{
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, List<GetBookQueryResult>>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public GetBookQueryHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetBookQueryResult>> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            List<Book> books = await _repository.GetAllAsync();

            return _mapper.Map<List<GetBookQueryResult>>(books);
        }
    }
}
