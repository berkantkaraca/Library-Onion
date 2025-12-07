using Library.Application.Mediator.Results.BookResults.QueryResults;
using MediatR;

namespace Library.Application.Mediator.Queries.BookQueries
{
    public class GetBookQuery : IRequest<List<GetBookQueryResult>>
    {

    }
}
