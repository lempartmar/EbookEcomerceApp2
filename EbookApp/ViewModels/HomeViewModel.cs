using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EbookApp.Models;

namespace EbookApp.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Ebook> Ebooki { get; set; }
        public IEnumerable<Category> Categorie { get; set; } 



    }
}