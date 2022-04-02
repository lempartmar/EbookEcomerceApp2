using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EbookApp.Models
{
    public class Ebook
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę ebooka:")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwę autora")]
        [StringLength(100)]
        public string AutorEbooka { get; set; }
        //public DateTime DataDodania { get; set; }
        [StringLength(100)]
        public string NazwaPlikuObrazka { get; set; }
        public string OpisEbooka { get; set; }
        public decimal CenaEbooka { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }
        public string OpisSkrocony { get; set; }

    }
}