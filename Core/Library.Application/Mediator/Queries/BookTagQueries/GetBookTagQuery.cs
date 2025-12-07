using Library.Application.Mediator.Results.BookTagResults.QueryResults;
using MediatR;

namespace Library.Application.Mediator.Queries.BookTagQueries
{
    public class GetBookTagQuery : IRequest<List<GetBookTagQueryResult>>
    {

    }
}
