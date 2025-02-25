using System.ComponentModel.DataAnnotations;

namespace sp311_mvc_project.Models
{
    public class Category
    {
        [Key]
        public string? Id { get; set; }
        [Required, MaxLength(150)]
        public string? Name { get; set; }
        public List<Product> Products { get; set; } = [];
    }
}