using AutoMapper;
using Library.Application.Mediator.Queries.BookTagQueries;
using Library.Application.Mediator.Results.BookTagResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Read.BookTagHandlers
{
    public class GetBookTagQueryHandler : IRequestHandler<GetBookTagQuery, List<GetBookTagQueryResult>>
    {
        private readonly IBookTagRepository _repository;
        private readonly IMapper _mapper;

        public GetBookTagQueryHandler(IBookTagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetBookTagQueryResult>> Handle(GetBookTagQuery request, CancellationToken cancellationToken)
        {
            List<BookTag> bookTags = await _repository.GetAllAsync();

            return _mapper.Map<List<GetBookTagQueryResult>>(bookTags);
        }
    }
}
