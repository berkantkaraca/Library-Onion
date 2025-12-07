using Library.Application.Mediator.Results.TagResults.QueryResults;
using MediatR;

namespace Library.Application.Mediator.Queries.TagQueries
{
    public class GetTagQuery : IRequest<List<GetTagQueryResult>>
    {

    }
}
