using AutoMapper;
using Library.Application.Mediator.Queries.CategoryQueries;
using Library.Application.Mediator.Results.CategoryResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Read.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public GetCategoryByIdQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            Category category = await _repository.GetByIdAsync(request.Id);

            return _mapper.Map<GetCategoryByIdQueryResult>(category);
        }
    }
}
