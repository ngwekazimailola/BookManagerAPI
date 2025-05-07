using System.ComponentModel.DataAnnotations;

namespace BookManagerAPI.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
