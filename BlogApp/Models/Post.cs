using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public int ParentId { get; set; }

        [Required]
        public string Title { get; set; }

        public string MetaTitle { get; set; }

        [Required]
        public string Slug { get; set; }

        public string Summary { get; set; }

        public bool IsPublished { get; set; }

        public DateTime PublishedAt { get; set; }

        public string Content { get; set; }
    }
}
