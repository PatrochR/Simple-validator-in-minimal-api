using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;

    }

    public class BookDto 
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
    }

    public static class BookExtension
    {
        public static BookDto BookToDto(this Book book) 
        {
            return new BookDto { Title =  book.Title, Description = book.Description };
        }
    }
}
