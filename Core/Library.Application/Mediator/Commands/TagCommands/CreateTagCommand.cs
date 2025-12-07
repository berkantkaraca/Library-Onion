using Library.Application.Mediator.Results.TagResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.TagCommands
{
    public class CreateTagCommand : IRequest<GetTagCommandResult>
    {
        public string Name { get; set; }
    }
}
