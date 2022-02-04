using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoffeeShop.Pages
{
    public class RateCoffeeModel : PageModel
    {
        private readonly AplicationDbContext _db;
        public static Coffee Coffee { get; set; }
        [BindProperty]
        public Rating Rating { get; set; }
        public List<Rating> IndexRatings { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<SelectedIngredient> SelectedIng { get; set; }
        public RateCoffeeModel(AplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Coffee = _db.Coffees.Find(id);
            var ingredientName = from c in _db.CoffeIngredients
                                 join sa in _db.Ingredients on c.IngredientId equals sa.Id
                                 where c.CoffeeId == id
                                 select new SelectedIngredient { Name = c.Ingredient.Name };

            SelectedIng = ingredientName.ToList();
            IndexRatings = _db.Ratings.Where(x => x.Coffee.Id == id).ToList();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Rating.CoffeeId = Coffee.Id;
                _db.Ratings.Add(Rating);
                _db.SaveChanges();
                TempData["Success"] = "Vaše Recenze Byla úspìšnì zveøejnìna!";
                return RedirectToPage("RateCoffee", new { id = Coffee.Id });
            }
            else
            {
                TempData["Error"] = "Musíte vyplnit všechny položky v formuláøi!";
                return Page();
            }

        }
    }
    public class SelectedIngredient
    {
        public string Name { get; set; }
    }
}
