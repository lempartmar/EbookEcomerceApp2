using EbookApp.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EbookApp.DAL
{
    public class EbookContext : IdentityDbContext<ApplicationUser>
    {

        public static EbookContext Create()
        {
            return new EbookContext();
        }

        public EbookContext() : base("EbookContext")
        {

        }

        public DbSet<Ebook> Ebooki { get; set; }
        //public DbSet<Category> Kategorie { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}