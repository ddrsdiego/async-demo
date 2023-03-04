namespace AsyncDemo.Services
{
    using Entities;

    public interface IBooksRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetById(string bookId);
        
        Task<IEnumerable<Book>> GetBooksAsync();

        Task<Book?> GetByIdAsync(string bookId);
    }
}