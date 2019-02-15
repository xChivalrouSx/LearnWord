using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnWord.Controllers
{
    public class WordController : Controller
    {
        // GET: Word
        public ActionResult Add()
        {
            return View();
        }
    }
}