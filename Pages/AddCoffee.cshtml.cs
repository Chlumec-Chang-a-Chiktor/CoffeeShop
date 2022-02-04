using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoffeeShop.Pages
{
    public class AddCoffeeModel : PageModel
    {
        private readonly AplicationDbContext _db;
        [BindProperty]
        public static List<Ingredient> CoffeIngredients { get; set; }
        public AddCoffeeModel(AplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Coffee Coffe { get; set; }
        [BindProperty]
        public List<int> CheckedId { get; set; }
        public void OnGet()
        {
            CoffeIngredients = _db.Ingredients.ToList();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                CoffeIngredients = _db.Ingredients.Where(x => CheckedId.Contains(x.Id)).ToList();
                Coffe.CoffeIngredients = new List<CoffeIngredient>();
                foreach (var item in CoffeIngredients)
                {
                    Coffe.CoffeIngredients.Add(new CoffeIngredient { CoffeeId = Coffe.Id, IngredientId = item.Id });
                }
                _db.Coffees.Add(Coffe);

                _db.SaveChanges();
                TempData["Success"] = $"Káva {Coffe.Name} byla úspìšnì pøijata!";
                return RedirectToPage("Index");
            }
            else
            {
                TempData["Error"] = "Jejda. nìco se nezdaøilo, prohlédnìte si pozornì formuláø";
                return Page();
            }

        }
    }
}
