using System.ComponentModel.DataAnnotations;

namespace Aqua_Garden.Models
{
    public class Aqua
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int ContactNumber { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

    }
}
