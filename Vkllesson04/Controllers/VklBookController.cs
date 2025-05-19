using Microsoft.AspNetCore.Mvc;
using Vkllesson04.Models;

namespace Vkllesson04.Controllers
{
    public class VklBookController : Controller
    {
        protected Book Book = new Book();
        public IActionResult VklIndex()
        {
            ViewBag.authors = Book.Authoers;
            ViewBag.generes = Book.Generes;
            var books = Book.GetBookList();
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.authors = Book.Authoers;
            ViewBag.generes = Book.Generes;
            Book model = new Book();
            return View(model);
        }
        public IActionResult CreateSubmit()
        {
            return RedirectToAction("VklIndex");
        }
        public IActionResult Edit(string Id)
        {
            ViewBag.authors = Book.Authoers;
            ViewBag.generes = Book.Generes;
            Book model = new Book();
            return View(model);
        }
        public IActionResult EditSubmit()
        {
            return RedirectToAction("VklIndex");
        }
    }
}
