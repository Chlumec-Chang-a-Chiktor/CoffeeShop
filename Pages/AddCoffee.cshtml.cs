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
        public AddCoffeeModel(AplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Coffee Coffe { get; set; }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Coffees.Add(Coffe);
                _db.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
            
        }
    }
}
