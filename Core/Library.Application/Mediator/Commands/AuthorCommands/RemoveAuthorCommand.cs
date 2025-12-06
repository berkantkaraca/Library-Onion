using Library.Application.Mediator.Results.AuthorResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.AuthorCommands
{
    public class RemoveAuthorCommand : IRequest<GetAuthorCommandResult>
    {
        public int Id { get; set; }

        public RemoveAuthorCommand(int id)
        {
            Id = id;
        }
    }
}
