using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class Determinant
    {
        public int DeterminantId { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public Country Country { get; set; }
        [Required]
        public string Name { get; set; }
        public string Technology { get; set; }
        [Required]
        public double Value { get; set; }
    }
}