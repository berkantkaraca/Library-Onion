using AutoMapper;
using Library.Application.Mediator.Commands.BookCommands;
using Library.Application.Mediator.Results.BookResults.CommandResults;
using Library.Contract.RepositoryInterfaces;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Mediator.Handlers.Modify.BookHandlers
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, GetBookCommandResult>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public UpdateBookCommandHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetBookCommandResult> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            Book book = await _repository.GetByIdAsync(request.Id);

            if (book == null)
                return null;

            _mapper.Map(request, book);

            book.UpdatedDate = DateTime.Now;
            book.Status = Domain.Enums.DataStatus.Updated;
            await _repository.SaveChangesAsync();

            return _mapper.Map<GetBookCommandResult>(book);
        }
    }
}
