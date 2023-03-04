namespace AsyncDemo.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Books")]
    public class Book
    {
        private Book()
        {
        }

        public static Book Default() => new();
        
        public Book(string bookId, string authorId, string title, string? description)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            AuthorId = authorId;
        }

        [Key] public string BookId { get; set; }

        [Required] [MaxLength(150)] public string Title { get; set; }

        [MaxLength(2500)] public string? Description { get; set; }

        public string AuthorId { get; set; }

        public Author Author { get; set; }
    }
}