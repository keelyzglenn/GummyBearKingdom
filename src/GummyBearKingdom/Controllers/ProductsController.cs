using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;


namespace GummyBearKingdom.Controllers
{
    public class ProductsController : Controller
    {

        private GummyBearDbContext db = new GummyBearDbContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}
