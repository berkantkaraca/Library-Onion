using AutoMapper;
using Library.Application.Mediator.Commands.CategoryCommands;
using Library.Application.Mediator.Results.CategoryResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.CategoryHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, GetCategoryCommandResult>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCategoryCommandResult> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            await _repository.CreateAsync(category);

            return _mapper.Map<GetCategoryCommandResult>(category);
        }
    }
}
