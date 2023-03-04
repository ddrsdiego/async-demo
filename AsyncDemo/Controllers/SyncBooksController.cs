namespace AsyncDemo.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services;

    [Route("api")]
    [ApiController]
    public class SyncBooksController : ControllerBase
    {
        private readonly IBooksRepository _booksRepository;

        public SyncBooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        [HttpGet("books/sync")]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _booksRepository.GetBooksAsync();
            return Ok(books);
        }
    }
}