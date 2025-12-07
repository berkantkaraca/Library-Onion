using Library.Application.Mediator.Results.TagResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.TagCommands
{
    public class RemoveTagCommand : IRequest<GetTagCommandResult>
    {
        public int Id { get; set; }
        public RemoveTagCommand(int id)
        {
            Id = id;
        }
    }
}
