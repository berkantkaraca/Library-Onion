using AutoMapper;
using Library.Application.Mediator.Queries.CategoryQueries;
using Library.Application.Mediator.Results.CategoryResults.QueryResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Read.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            List<Category> categories = await _repository.GetAllAsync();

            return _mapper.Map<List<GetCategoryQueryResult>>(categories);
        }
    }
}
