using Library.Application.Mediator.Results.BookResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.BookCommands
{
    public class CreateBookCommand : IRequest<GetBookCommandResult>
    {
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }
    }
}
