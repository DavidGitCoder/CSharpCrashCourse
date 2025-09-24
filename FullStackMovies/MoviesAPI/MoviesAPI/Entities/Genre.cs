using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
    }
}
