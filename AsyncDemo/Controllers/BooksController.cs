namespace AsyncDemo.Controllers
{
    using Entities;
    using Microsoft.AspNetCore.Mvc;
    using Services;

    [Route("api")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _booksRepository;

        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        [HttpGet("books")]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _booksRepository.GetBooksAsync();
            return Ok(books);
        }
        
        [HttpGet("books/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var book = await _booksRepository.GetByIdAsync(id);
            if (book != null || book.BookId.Equals(Book.Default().BookId))
                return NotFound();

            return Ok(book);
        }
    }
}