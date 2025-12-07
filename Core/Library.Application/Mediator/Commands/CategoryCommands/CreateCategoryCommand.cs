using Library.Application.Mediator.Results.CategoryResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest<GetCategoryCommandResult>
    {
        public string Name { get; set; }
    }
}
