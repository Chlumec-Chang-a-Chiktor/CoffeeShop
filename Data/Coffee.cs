using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Data
{
    public class Coffee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debílku Jméno je povinný")]
        [MaxLength(100, ErrorMessage = "Název nemůže mít víc než 100 znaků!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ale to musí mít popisek čtyřihlava")]
        [MaxLength(1500, ErrorMessage = "Popisek nemůže mít víc než 1500 znaků!")]
        public string Description { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
        public IList<CoffeIngredient>  CoffeIngredients { get; set; }

    }
}
