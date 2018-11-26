using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WordCount.Controllers
{
    public class WordController : Controller
    {
        // GET: Word
        public ActionResult List()
        {
            XMLReader read = new XMLReader();
            var data = read.ReturnWord();
            return View(data);
        }
        
    }
}