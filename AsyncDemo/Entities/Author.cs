namespace AsyncDemo.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Authors")]
    public class Author
    {
        public Author(string authorId, string firstName, string lastName)
        {
            AuthorId = authorId;
            FirstName = firstName;
            LastName = lastName;
        }

        [Key] public string AuthorId { get; set; }

        [Required] [MaxLength(150)] public string FirstName { get; set; }

        [Required] [MaxLength(150)] public string LastName { get; set; }
    }
}