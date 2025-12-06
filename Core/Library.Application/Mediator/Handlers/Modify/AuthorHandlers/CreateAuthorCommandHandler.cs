using AutoMapper;
using Library.Application.Mediator.Commands.AuthorCommands;
using Library.Application.Mediator.Results.AuthorResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.AuthorHandlers
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, GetAuthorCommandResult>
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public CreateAuthorCommandHandler(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAuthorCommandResult> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _mapper.Map<Author>(request);
            await _repository.CreateAsync(author);

            return _mapper.Map<GetAuthorCommandResult>(author);
        }
    }
}
