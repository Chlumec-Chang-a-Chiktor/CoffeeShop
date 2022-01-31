using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Data
{
    public class CoffeIngredient
    {
        public int CoffeeId { get; set; }
        public int IngredientId { get; set; }
        [ForeignKey("CoffeeId")]
        public Coffee Coffee { get; set; }
        [ForeignKey("IngredientId")]
        public Ingredient Ingredient { get; set; }
    }
}
