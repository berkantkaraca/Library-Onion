using Library.Application.Mediator.Results.CategoryResults.CommandResults;
using MediatR;

namespace Library.Application.Mediator.Commands.CategoryCommands
{
    public class RemoveCategoryCommand : IRequest<GetCategoryCommandResult>
    {
        public int Id { get; set; }
        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
