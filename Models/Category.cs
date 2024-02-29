using System.ComponentModel.DataAnnotations;

namespace ApiPelicula.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
