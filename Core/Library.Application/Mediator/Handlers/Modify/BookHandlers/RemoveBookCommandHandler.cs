using AutoMapper;
using Library.Application.Mediator.Commands.BookCommands;
using Library.Application.Mediator.Results.BookResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.BookHandlers
{
    public class RemoveBookCommandHandler : IRequestHandler<RemoveBookCommand, GetBookCommandResult>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public RemoveBookCommandHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBookCommandResult> Handle(RemoveBookCommand request, CancellationToken cancellationToken)
        {
            Book book = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(book);

            return _mapper.Map<GetBookCommandResult>(book);
        }
    }
}
