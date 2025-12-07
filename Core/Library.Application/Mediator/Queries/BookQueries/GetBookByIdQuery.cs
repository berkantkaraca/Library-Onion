using Library.Application.Mediator.Results.BookResults.QueryResults;
using MediatR;

namespace Library.Application.Mediator.Queries.BookQueries
{
    public class GetBookByIdQuery : IRequest<GetBookByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBookByIdQuery(int id)
        {
            Id = id;
        }
    }
}
