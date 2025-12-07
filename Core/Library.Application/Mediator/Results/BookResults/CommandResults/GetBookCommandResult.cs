namespace Library.Application.Mediator.Results.BookResults.CommandResults
{
    public class GetBookCommandResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }
    }
}
