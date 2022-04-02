namespace EbookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AktualizacjaModelu2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ebook", "DataDodania");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ebook", "DataDodania", c => c.DateTime(nullable: false));
        }
    }
}
