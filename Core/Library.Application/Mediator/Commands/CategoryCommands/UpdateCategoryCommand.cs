using Library.Application.Mediator.Results.CategoryResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.CategoryCommands
{
    public class UpdateCategoryCommand : IRequest<GetCategoryCommandResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
