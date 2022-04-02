using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EbookApp.Models;
using EbookApp.ViewModels;

namespace EbookApp.Controllers
{
    
    public class EbookController : Controller
    {
        private DAL.EbookContext db = new DAL.EbookContext();
        // GET: Ebook
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Szczegoly(int id)
        {
            List<Ebook> listaEbook = Data.DataManager.EbookList();
            Ebook ebook = db.Ebooki.Where(e => e.Id == id).FirstOrDefault();
            return View(ebook);

        }
    }
}