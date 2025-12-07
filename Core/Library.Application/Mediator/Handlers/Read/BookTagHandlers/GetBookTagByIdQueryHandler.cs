using AutoMapper;
using Library.Application.Mediator.Queries.BookTagQueries;
using Library.Application.Mediator.Results.BookTagResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;
using System.Linq;

namespace Library.Application.Mediator.Handlers.Read.BookTagHandlers
{
    public class GetBookTagByIdQueryHandler : IRequestHandler<GetBookTagByIdQuery, GetBookTagQueryResult>
    {
        private readonly IBookTagRepository _repository;
        private readonly IMapper _mapper;

        public GetBookTagByIdQueryHandler(IBookTagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBookTagQueryResult> Handle(GetBookTagByIdQuery request, CancellationToken cancellationToken)
        {
            var all = await _repository.GetAllAsync();
            var existing = all.FirstOrDefault(x => x.BookId == request.BookId && x.TagId == request.TagId);

            return _mapper.Map<GetBookTagQueryResult>(existing);
        }
    }
}
