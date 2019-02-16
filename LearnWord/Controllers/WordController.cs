using LearnWord.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LearnWord.Controllers
{
    public class WordController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WordController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Add()
        {
            var model = new WordModels();

            return View(model);
        }
    }
}