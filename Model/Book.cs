using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

    }
}
