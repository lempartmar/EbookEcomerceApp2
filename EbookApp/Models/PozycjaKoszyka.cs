using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EbookApp.Models
{
    public class PozycjaKoszyka
    {
        public Ebook EbookKoszyk { get; set; }
        public int Ilosc { get; set; } 
        public decimal Wartosc { get; set; }




    }
}