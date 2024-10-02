namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Genre");
        }
    }
}
