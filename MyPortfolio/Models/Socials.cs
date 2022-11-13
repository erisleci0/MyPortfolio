using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Socials
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }
        public string Icon { get; set; }
    }
}
