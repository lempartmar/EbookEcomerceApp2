namespace EbookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AktualizacjaModelu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ebook", "AutorEbooka", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Ebook", "DataDodania", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ebook", "NazwaPlikuObrazka", c => c.String(maxLength: 100));
            AddColumn("dbo.Ebook", "OpisEbooka", c => c.String());
            AddColumn("dbo.Ebook", "CenaEbooka", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Ebook", "Bestseller", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ebook", "Ukryty", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ebook", "OpisSkrocony", c => c.String());
            AlterColumn("dbo.Ebook", "Title", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ebook", "Title", c => c.String());
            DropColumn("dbo.Ebook", "OpisSkrocony");
            DropColumn("dbo.Ebook", "Ukryty");
            DropColumn("dbo.Ebook", "Bestseller");
            DropColumn("dbo.Ebook", "CenaEbooka");
            DropColumn("dbo.Ebook", "OpisEbooka");
            DropColumn("dbo.Ebook", "NazwaPlikuObrazka");
            DropColumn("dbo.Ebook", "DataDodania");
            DropColumn("dbo.Ebook", "AutorEbooka");
        }
    }
}
