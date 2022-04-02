using EbookApp.DAL;
using EbookApp.Infrastructure;
using EbookApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EbookApp.Controllers
{
    public class KoszykController : Controller
    {

        private KoszykManager koszykManager;
        private ISessionManager sessionManager { get; set; }
        private EbookContext db;
        // GET: Koszyk
        public KoszykController()
        {
            sessionManager = new SessionManager();
            koszykManager = new KoszykManager(sessionManager, db);
        }
        public ActionResult Index()
        {
            var pozycjeKoszyka = koszykManager.PobierzKoszyk();
            var cenaCalkowita = koszykManager.PobierzWartoscKoszyk();

            KoszykViewModel koszykVM = new KoszykViewModel()
            {
                PozycjeKoszyka = pozycjeKoszyka,

            };
            return View(koszykVM);
        }

        public ActionResult DodajDoKoszyka(int id)
        {

            koszykManager.DodajDoKoszyka(id);
            return RedirectToAction("Index");

        }


    }
}