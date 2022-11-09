using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
