using Library.Application.Mediator.Commands.BookTagCommands;
using Library.Application.Mediator.Queries.BookTagQueries;
using Library.Application.Mediator.Results.BookTagResults.QueryResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTagController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookTagController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BookTagList()
        {
            List<GetBookTagQueryResult> values = await _mediator.Send(new GetBookTagQuery());
            return Ok(values);
        }

        [HttpGet("{bookId}/{tagId}")]
        public async Task<IActionResult> GetBookTag(int bookId, int tagId)
        {
            var value = await _mediator.Send(new GetBookTagByIdQuery(bookId, tagId));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBookTag(CreateBookTagCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBookTag(UpdateBookTagCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{bookId}/{tagId}")]
        public async Task<IActionResult> DeleteBookTag(int bookId, int tagId)
        {
            var result = await _mediator.Send(new RemoveBookTagCommand(bookId, tagId));
            return Ok(result);
        }
    }
}
