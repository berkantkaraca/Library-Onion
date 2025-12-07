using AutoMapper;
using Library.Application.Mediator.Commands.CategoryCommands;
using Library.Application.Mediator.Results.CategoryResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.CategoryHandlers
{
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand, GetCategoryCommandResult>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public RemoveCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCategoryCommandResult> Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(category);

            return _mapper.Map<GetCategoryCommandResult>(category);
        }
    }
}
