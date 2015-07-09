namespace MyRESTService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertisement",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Title = c.String(),
                        Picture = c.String(),
                        ClientId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Catagory", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Catagory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CatagoryName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        PackageName = c.String(),
                        ContactPerson = c.String(),
                        ContactPhone = c.String(),
                        ContactEmail = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        CellNo = c.String(nullable: false),
                        RegistrationId = c.String(),
                        CanSendNotification = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Make = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Color = c.String(),
                        VehicleType = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Catagory", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicle", "Id", "dbo.Catagory");
            DropForeignKey("dbo.Advertisement", "ClientId", "dbo.Client");
            DropForeignKey("dbo.Advertisement", "CategoryId", "dbo.Catagory");
            DropIndex("dbo.Vehicle", new[] { "Id" });
            DropIndex("dbo.Advertisement", new[] { "CategoryId" });
            DropIndex("dbo.Advertisement", new[] { "ClientId" });
            DropTable("dbo.Vehicle");
            DropTable("dbo.Person");
            DropTable("dbo.Client");
            DropTable("dbo.Catagory");
            DropTable("dbo.Advertisement");
        }
    }
}
