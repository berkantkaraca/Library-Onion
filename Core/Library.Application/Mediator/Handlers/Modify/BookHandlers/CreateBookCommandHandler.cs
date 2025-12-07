using AutoMapper;
using Library.Application.Mediator.Commands.BookCommands;
using Library.Application.Mediator.Results.BookResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.BookHandlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, GetBookCommandResult>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public CreateBookCommandHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBookCommandResult> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request);
            await _repository.CreateAsync(book);

            return _mapper.Map<GetBookCommandResult>(book);
        }
    }
}
