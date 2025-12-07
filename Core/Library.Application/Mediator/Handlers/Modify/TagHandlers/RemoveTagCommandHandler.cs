using AutoMapper;
using Library.Application.Mediator.Commands.TagCommands;
using Library.Application.Mediator.Results.TagResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.TagHandlers
{
    public class RemoveTagCommandHandler : IRequestHandler<RemoveTagCommand, GetTagCommandResult>
    {
        private readonly ITagRepository _repository;
        private readonly IMapper _mapper;

        public RemoveTagCommandHandler(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetTagCommandResult> Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            Tag tag = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(tag);

            return _mapper.Map<GetTagCommandResult>(tag);
        }
    }
}
