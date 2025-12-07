using AutoMapper;
using Library.Application.Mediator.Queries.TagQueries;
using Library.Application.Mediator.Results.TagResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Read.TagHandlers
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly ITagRepository _repository;
        private readonly IMapper _mapper;

        public GetTagByIdQueryHandler(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            Tag tag = await _repository.GetByIdAsync(request.Id);

            return _mapper.Map<GetTagByIdQueryResult>(tag);
        }
    }
}
