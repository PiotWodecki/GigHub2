using System.ComponentModel.DataAnnotations;

namespace GigHub2.Models
{
    public class Genre
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public byte Id { get; set; }
    }
}