namespace BookApi.Controllers
{
    using BookApi.Models;
    using BookApi.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("sorted-by-publisher-author-title")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksSortedByPublisherAuthorTitle()
        {
            var books = await _bookService.GetBooksSortedByPublisherAuthorTitleAsync();
            return Ok(books);
        }

        [HttpGet("sorted-by-author-title")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksSortedByAuthorTitle()
        {
            var books = await _bookService.GetBooksSortedByAuthorTitleAsync();
            return Ok(books);
        }

        [HttpGet("total-price")]
        public async Task<ActionResult<decimal>> GetTotalPrice()
        {
            var totalPrice = await _bookService.GetTotalPriceAsync();
            return Ok(totalPrice);
        }

        [HttpPost("save-books")]
        public async Task<IActionResult> SaveBooks([FromBody] IEnumerable<Book> books)
        {
            if (books == null || !books.Any())
            {
                return BadRequest("Book list cannot be null or empty.");
            }

            await _bookService.SaveBooksAsync(books);
            return CreatedAtAction(nameof(GetBooksSortedByPublisherAuthorTitle), new { count = books.Count() }, books);
        }
    }
}
