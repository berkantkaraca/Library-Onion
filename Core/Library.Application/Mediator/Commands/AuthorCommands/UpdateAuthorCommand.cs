using Library.Application.Mediator.Results.AuthorResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.AuthorCommands
{
    public class UpdateAuthorCommand : IRequest<GetAuthorCommandResult>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
