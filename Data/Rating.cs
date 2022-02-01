using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Data
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        public int CoffeeId { get; set; }
        [ForeignKey("CoffeeId")]
        public Coffee Coffee { get; set; }
        [Required]
        [Range(0,10)]
        public int Points { get; set; }
    }
}
