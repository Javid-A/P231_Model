using Microsoft.AspNetCore.Mvc;
using P231_Model.Model;

namespace P231_Model.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            #region ViewBag
            ViewBag.ProductName = "Product 1";
            //ViewBag.ProductPrice = 55.67;
            //ViewBag.Product = new Product()
            //{
            //    Id = 5,
            //    Name = "Lenovo",
            //    Price = 5678.6,
            //    Ram = "16GB"
            //}; 
            #endregion

            #region ViewData
            ViewData["Ram"] = "32GB";

            //ViewData["User"] = new User
            //{
            //    Id = 1,
            //    Username = "Mubariz",
            //    Password = "mubariz123"
            //};
            //ViewData["User"] = null;
            #endregion


            #region Temporary data
            TempData["Username"] = "Xalid"; 
            #endregion

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
