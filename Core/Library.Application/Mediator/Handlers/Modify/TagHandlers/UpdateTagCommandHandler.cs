using AutoMapper;
using Library.Application.Mediator.Commands.TagCommands;
using Library.Application.Mediator.Results.TagResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.TagHandlers
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, GetTagCommandResult>
    {
        private readonly ITagRepository _repository;
        private readonly IMapper _mapper;

        public UpdateTagCommandHandler(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetTagCommandResult> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            Tag tag = await _repository.GetByIdAsync(request.Id);

            if (tag == null)
                return null;

            _mapper.Map(request, tag);

            tag.UpdatedDate = DateTime.Now;
            tag.Status = Domain.Enums.DataStatus.Updated;
            await _repository.SaveChangesAsync();

            return _mapper.Map<GetTagCommandResult>(tag);
        }
    }
}
