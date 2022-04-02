using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EbookApp.Models;
using EbookApp.ViewModels;
using EbookApp.Data;
using EbookApp.DAL;

namespace EbookApp.Controllers
{
    public class HomeController : Controller
    {


        private EbookContext db = new EbookContext();
        
        public ActionResult Index()
        {
        //public int Id { get; set; }
        //public string Title { get; set; }
        //public string AutorEbooka { get; set; }
        //public DateTime DataDodania { get; set; }
        //public string NazwaPlikuObrazka { get; set; }
        //public string OpisEbooka { get; set; }
        //public decimal CenaEbooka { get; set; }
        //public bool Bestseller { get; set; }
        //public bool Ukryty { get; set; }
        //public string OpisSkrocony { get; set; }

            Ebook ebook1 = new Ebook() { Title = "Learn basics of C#", Id = 1, AutorEbooka = "John Johnson", NazwaPlikuObrazka = "Ebook1", OpisEbooka = "Książka skupia się na rozwiązaniach Designu na świecie", 
                                        CenaEbooka = 19.9m};
            Ebook ebook2 = new Ebook() 
            {
                Title = "Journey Of Life",
                Id = 2,
                AutorEbooka = "John Wilson",
                NazwaPlikuObrazka = "Ebook2",
                OpisEbooka = "Książka o długiej podróży przez życie uchodźcy z Pakistanu.",
                CenaEbooka = 19.9m
            };

            Ebook ebook3 = new Ebook()
            {
                Title = "Technology Media",
                Id = 3,
                AutorEbooka = "Rudy Setyawan",
                NazwaPlikuObrazka = "Ebook3",
                OpisEbooka = "Książka rozwiewa wszelkie wątpliwości dotyczące walki dobra ze złem w przestrzeni technologii mediów.",
                CenaEbooka = 19.9m
            };


            Ebook ebook4 = new Ebook()
            {
                Title = "Love in the City",
                Id = 4,
                AutorEbooka = "Estelle Darcy",
                NazwaPlikuObrazka = "Ebook4",
                OpisEbooka = "Książka przedstawia życie dwóch nastalatków w Nowym Jorku.",
                CenaEbooka = 19.9m
            };

            Ebook ebook5 = new Ebook()
            {
                Title = "Money Hacks",
                Id = 5,
                AutorEbooka = "Reese Miller",
                NazwaPlikuObrazka = "Ebook5",
                OpisEbooka = "Autor rozwiewa wszelkie wątpliwości dotyczące procesu oszczędzania w ramach budżetu rodzinnego.",
                CenaEbooka = 19.9m
            };

            Ebook ebook6= new Ebook()
            {
                Title = "Hacks how to succed in life",
                Id = 6,
                AutorEbooka = "Brigitte Swartz",
                NazwaPlikuObrazka = "Ebook6.jpg",
                OpisEbooka = "10 kroków do odniesienia sukcesu w życiu.",
                CenaEbooka = 29.99m
            };

            Ebook ebook7 = new Ebook()
            {
                Title = "The ultimate 101 guide to freelancing",
                Id = 7,
                AutorEbooka = "n/a",
                NazwaPlikuObrazka = "Ebook7.jpg",
                OpisEbooka = "101 podpowiedzi jak osiągnąć sukces jako freelancer.",
                CenaEbooka = 29.99m
            };

            Ebook ebook8 = new Ebook()
            {
                Title = "The book of art",
                Id = 7,
                AutorEbooka = "Takehiro Kanegi",
                NazwaPlikuObrazka = "Ebook8.jpg",
                OpisEbooka = "Wprowadzenie do świata sztuki. Przewodnik po sztuce współczesnej.",
                CenaEbooka = 89.99m
            };
            //db.Ebooki.Add(ebook1);
            //db.Ebooki.Add(ebook2);
            //db.Ebooki.Add(ebook3);
            //db.Ebooki.Add(ebook4);
            //db.Ebooki.Add(ebook5);
            //db.Ebooki.Add(ebook6);
            //db.Ebooki.Add(ebook7);
            //db.Ebooki.Add(ebook8);

            //db.SaveChanges();
            HomeViewModel vm = new HomeViewModel();

            //vm.Ebooki = Data.DataManager.EbookList();
            vm.Ebooki = db.Ebooki.Where(a => a.Ukryty == false).Take(3).ToList();
            vm.Categorie = Data.DataManager.CategoryList();


            return View(vm);
        }

        public ActionResult Statyczne(string nazwa)
        {
            return View(nazwa);
        }

        public ActionResult Przyklad()
        {
            return View();
        }

        public ActionResult KursyLista()
        {
            HomeViewModel vm = new HomeViewModel();
            vm.Ebooki = db.Ebooki.Where(a => a.Ukryty == false).ToList();
            vm.Categorie = Data.DataManager.CategoryList();
            return View(vm);
           
        }




    }
}