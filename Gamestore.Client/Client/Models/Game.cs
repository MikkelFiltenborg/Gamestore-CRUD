using System.ComponentModel.DataAnnotations;

namespace Gamestore.Client.Client.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(176)]
        public required string Name { get; set; }

        [Required]
        [StringLength(15)]
        public required string Genre { get; set; }

        [Range(0, 150)]
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
