namespace WebAppMvc2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class instadbv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nom = c.String(nullable: false, maxLength: 60),
                        prenom = c.String(nullable: false, maxLength: 60),
                        email = c.String(nullable: false),
                        address = c.String(),
                        cp = c.String(),
                        ville = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Reference = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 1000),
                        imageUrl = c.String(),
                        prix = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produits");
            DropTable("dbo.Clients");
        }
    }
}
