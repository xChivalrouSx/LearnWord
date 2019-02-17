using LearnWord.Models;
using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        [Authorize]
        public ActionResult Add()
        {
            return View(new WordModels());
        }

        [Authorize]
        [HttpPost]
        public ActionResult Add(WordModels model)
        {
            model.UserId = User.Identity.GetUserId();
            ModelState["UserId"].Errors.Clear();

            if (!ModelState.IsValid)
            {
                return View(new WordModels());
            }

            _context.Words.Add(model);
            _context.SaveChanges();

            return RedirectToAction("List", "Word");
        }

        [Authorize]
        public ActionResult List()
        {
            string userId = User.Identity.GetUserId();
            var model = _context.Words
                .Where(w => w.UserId.Equals(userId)).ToList();

            return View(model);
        }
    }
}