using Library.Application.Mediator.Results.AuthorResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.AuthorCommands
{
    public class CreateAuthorCommand : IRequest<GetAuthorCommandResult>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
