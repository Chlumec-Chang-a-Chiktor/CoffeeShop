using CoffeeShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AplicationDbContext _db;
        private readonly ILogger<IndexModel> _logger;
        public List<Coffee> IndexCoffees { get; set; }

        public IndexModel(ILogger<IndexModel> logger, AplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            IndexCoffees = _db.Coffees.OrderByDescending(x => x.Id).ToList();
        }
    }
}
