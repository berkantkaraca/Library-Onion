using AutoMapper;
using Library.Application.Mediator.Queries.TagQueries;
using Library.Application.Mediator.Results.TagResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Read.TagHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        private readonly ITagRepository _repository;
        private readonly IMapper _mapper;

        public GetTagQueryHandler(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            List<Tag> tags = await _repository.GetAllAsync();

            return _mapper.Map<List<GetTagQueryResult>>(tags);
        }
    }
}
