using AutoMapper;
using Library.Application.Mediator.Commands.BookTagCommands;
using Library.Application.Mediator.Results.BookTagResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;
using System.Linq;

namespace Library.Application.Mediator.Handlers.Modify.BookTagHandlers
{
    public class UpdateBookTagCommandHandler : IRequestHandler<UpdateBookTagCommand, GetBookTagCommandResult>
    {
        private readonly IBookTagRepository _repository;
        private readonly IMapper _mapper;

        public UpdateBookTagCommandHandler(IBookTagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBookTagCommandResult> Handle(UpdateBookTagCommand request, CancellationToken cancellationToken)
        {
            // composite key, find existing via repository
            var all = await _repository.GetAllAsync();
            var existing = all.FirstOrDefault(x => x.BookId == request.BookId && x.TagId == request.TagId);
            if (existing == null)
                return null;

            // no real fields to update besides keys; but keep pattern
            existing.UpdatedDate = DateTime.Now;
            existing.Status = Domain.Enums.DataStatus.Updated;
            await _repository.SaveChangesAsync();

            return _mapper.Map<GetBookTagCommandResult>(existing);
        }
    }
}
