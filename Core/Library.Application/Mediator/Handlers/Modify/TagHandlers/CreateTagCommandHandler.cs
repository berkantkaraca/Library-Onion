using AutoMapper;
using Library.Application.Mediator.Commands.TagCommands;
using Library.Application.Mediator.Results.TagResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, GetTagCommandResult>
    {
        private readonly ITagRepository _repository;
        private readonly IMapper _mapper;

        public CreateTagCommandHandler(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetTagCommandResult> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var tag = _mapper.Map<Tag>(request);
            await _repository.CreateAsync(tag);

            return _mapper.Map<GetTagCommandResult>(tag);
        }
    }
}
