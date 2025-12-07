using AutoMapper;
using Library.Application.Mediator.Commands.BookTagCommands;
using Library.Application.Mediator.Results.BookTagResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.BookTagHandlers
{
    public class CreateBookTagCommandHandler : IRequestHandler<CreateBookTagCommand, GetBookTagCommandResult>
    {
        private readonly IBookTagRepository _repository;
        private readonly IMapper _mapper;

        public CreateBookTagCommandHandler(IBookTagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBookTagCommandResult> Handle(CreateBookTagCommand request, CancellationToken cancellationToken)
        {
            var bookTag = _mapper.Map<BookTag>(request);
            await _repository.CreateAsync(bookTag);

            return _mapper.Map<GetBookTagCommandResult>(bookTag);
        }
    }
}
