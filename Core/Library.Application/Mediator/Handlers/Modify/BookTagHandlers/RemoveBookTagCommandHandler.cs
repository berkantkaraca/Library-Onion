using AutoMapper;
using Library.Application.Mediator.Commands.BookTagCommands;
using Library.Application.Mediator.Results.BookTagResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;
using System.Linq;

namespace Library.Application.Mediator.Handlers.Modify.BookTagHandlers
{
    public class RemoveBookTagCommandHandler : IRequestHandler<RemoveBookTagCommand, GetBookTagCommandResult>
    {
        private readonly IBookTagRepository _repository;
        private readonly IMapper _mapper;

        public RemoveBookTagCommandHandler(IBookTagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBookTagCommandResult> Handle(RemoveBookTagCommand request, CancellationToken cancellationToken)
        {
            var all = await _repository.GetAllAsync();
            var existing = all.FirstOrDefault(x => x.BookId == request.BookId && x.TagId == request.TagId);
            if (existing == null)
                return null;

            await _repository.DeleteAsync(existing);

            return _mapper.Map<GetBookTagCommandResult>(existing);
        }
    }
}
