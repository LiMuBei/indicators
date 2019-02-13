using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class Country
    {
        [Key]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}