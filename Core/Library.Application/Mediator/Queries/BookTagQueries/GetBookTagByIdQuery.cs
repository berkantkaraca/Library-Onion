using Library.Application.Mediator.Results.BookTagResults.QueryResults;
using MediatR;

namespace Library.Application.Mediator.Queries.BookTagQueries
{
    public class GetBookTagByIdQuery : IRequest<GetBookTagQueryResult>
    {
        public int BookId { get; set; }
        public int TagId { get; set; }

        public GetBookTagByIdQuery(int bookId, int tagId)
        {
            BookId = bookId;
            TagId = tagId;
        }
    }
}
