using Library.Application.Mediator.Results.BookTagResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.BookTagCommands
{
    public class CreateBookTagCommand : IRequest<GetBookTagCommandResult>
    {
        public int BookId { get; set; }
        public int TagId { get; set; }
    }
}
