using Library.Application.Mediator.Results.TagResults.QueryResults;
using MediatR;

namespace Library.Application.Mediator.Queries.TagQueries
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTagByIdQuery(int id)
        {
            Id = id;
        }
    }
}
