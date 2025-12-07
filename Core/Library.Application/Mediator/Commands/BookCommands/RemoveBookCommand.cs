using Library.Application.Mediator.Results.BookResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.BookCommands
{
    public class RemoveBookCommand : IRequest<GetBookCommandResult>
    {
        public int Id { get; set; }
        public RemoveBookCommand(int id)
        {
            Id = id;
        }
    }
}
