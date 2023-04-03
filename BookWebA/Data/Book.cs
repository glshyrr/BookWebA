using System.ComponentModel.DataAnnotations;

namespace BookWebA.Data
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
        public int? PublisherId { get; set; } 
        public virtual Publisher? Publisher { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }

    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book>? Books { get; set;}
    }

    public class Category
    {
        public int Id { get; set; }
		[MaxLength(20)]
		public string Name { get; set; }
        public virtual List<Book>? Books { get; set; } = new List<Book>();
    }
}
