using AutoMapper;
using Library.Application.Mediator.Commands.CategoryCommands;
using Library.Application.Mediator.Results.CategoryResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, GetCategoryCommandResult>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCategoryCommandResult> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = await _repository.GetByIdAsync(request.Id);

            if (category == null)
                return null;

            _mapper.Map(request, category);

            category.UpdatedDate = DateTime.Now;
            category.Status = Domain.Enums.DataStatus.Updated;
            await _repository.SaveChangesAsync();

            return _mapper.Map<GetCategoryCommandResult>(category);
        }
    }
}
