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
        public RateCoffeeModel(AplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Coffee = _db.Coffees.Find(id);
            IndexRatings = _db.Ratings.Where(x => x.Coffee.Id == id).ToList();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Rating.CoffeeId = Coffee.Id;
                _db.Ratings.Add(Rating);
                _db.SaveChanges();

                return RedirectToPage("RateCoffee", new { id = Coffee.Id });
            }
            else
            {
                return Page();
            }
            
        }
    }
}
