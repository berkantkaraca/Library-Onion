using Library.Application.Mediator.Results.CategoryResults.QueryResults;
using MediatR;

namespace Library.Application.Mediator.Queries.CategoryQueries
{
    public class GetCategoryQuery : IRequest<List<GetCategoryQueryResult>>
    {

    }
}
