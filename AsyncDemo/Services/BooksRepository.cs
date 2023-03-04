namespace AsyncDemo.Services
{
    using DbContexts;
    using Entities;
    using Microsoft.EntityFrameworkCore;

    internal sealed class BooksRepository : IBooksRepository
    {
        private readonly BookContext _bookContext;

        public BooksRepository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _bookContext.Books
                .Include(b => b.Author)
                .ToList();
        }

        public Book GetById(string bookId)
        {
            var book = Book.Default();

            book = _bookContext.Books
                .Include(b => b.Author)
                .FirstOrDefault(b => b.BookId == bookId);

            return book;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _bookContext.Books
                .Include(b => b.Author)
                .ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(string bookId)
        {
            var book = Book.Default();

            book = await _bookContext.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.BookId == bookId);

            return book;
        }
    }
}