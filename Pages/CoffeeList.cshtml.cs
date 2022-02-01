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
    public class CoffeeListModel : PageModel
    {
        private readonly AplicationDbContext _db;
        private readonly ILogger<CoffeeListModel> _logger;
        public List<Coffee> CoffeeList { get; set; }

        public CoffeeListModel(ILogger<CoffeeListModel> logger, AplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            CoffeeList = _db.Coffees.OrderByDescending(x => x.Id).ToList();
        }
    }
}
