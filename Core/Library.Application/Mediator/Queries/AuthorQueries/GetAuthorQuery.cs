using Library.Application.Mediator.Results.AuthorResults.QueryResults;
using MediatR;

namespace Library.Application.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
    {

    }
}
