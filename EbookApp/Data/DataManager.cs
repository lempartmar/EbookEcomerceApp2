using System;
using System.Collections.Generic;
using System.Linq;
using EbookApp.Models;
using EbookApp.ViewModels;
using System.Web;

namespace EbookApp.Data
{
    public class DataManager
    {
        public static List<Ebook> EbookList()
        {
            List<Ebook> list_ebook = new List<Ebook>();
            var ebook1 = new Ebook() { Title = "Tytuł1", Id = 0 };
            var ebook2 = new Ebook() { Title = "Tytuł2", Id = 1 };
            var ebook3 = new Ebook() { Title = "Tytuł3", Id = 2 };
            var ebook4 = new Ebook() { Title = "Tytuł4", Id = 3 };

            list_ebook.Add(ebook1);
            list_ebook.Add(ebook2);
            list_ebook.Add(ebook3);
            list_ebook.Add(ebook4);

            return list_ebook;
            

        }

        public static List<Category> CategoryList()
        {
            List<Category> list_category = new List<Category>();
            var category1 = new Category() { Opis = "juice", Promocja = "up to 44% off" };
            var category2 = new Category() { Opis = "meat", Promocja = "upto 35% off" };
            Category category3 = new Category() { Opis = "fruite", Promocja = "up to 12% off" };

            list_category.Add(category1);
            list_category.Add(category2);
            list_category.Add(category3);

            return list_category;
        }

    }
}