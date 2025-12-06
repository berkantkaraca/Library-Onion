using AutoMapper;
using Library.Application.Mediator.Commands.AuthorCommands;
using Library.Application.Mediator.Results.AuthorResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.AuthorHandlers
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommand, GetAuthorCommandResult>
    {
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;

        public RemoveAuthorCommandHandler(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAuthorCommandResult> Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
        {
            Author author = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(author);

            return _mapper.Map<GetAuthorCommandResult>(author);
        }
    }
}
