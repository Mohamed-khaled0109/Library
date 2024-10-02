namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        price = c.Double(nullable: false),
                        AutherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authers", t => t.AutherId, cascadeDelete: true)
                .Index(t => t.AutherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AutherId", "dbo.Authers");
            DropIndex("dbo.Books", new[] { "AutherId" });
            DropTable("dbo.Books");
            DropTable("dbo.Authers");
        }
    }
}
