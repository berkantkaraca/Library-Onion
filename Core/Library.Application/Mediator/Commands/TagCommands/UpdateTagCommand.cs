using Library.Application.Mediator.Results.TagResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.TagCommands
{
    public class UpdateTagCommand : IRequest<GetTagCommandResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
