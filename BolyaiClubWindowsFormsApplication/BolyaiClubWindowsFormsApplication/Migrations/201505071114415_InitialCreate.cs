namespace BolyaiClubWindowsFormsApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Mobile = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Renter",
                c => new
                    {
                        RenterId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        IsNonProfit = c.Boolean(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RenterId)
                .ForeignKey("dbo.User", t => t.CreatedBy)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId)
                .Index(t => t.CreatedBy);
            
            CreateTable(
                "dbo.Rent",
                c => new
                    {
                        RentId = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        RenterId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        PriceId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        IsFinished = c.Boolean(nullable: false),
                        Cost = c.Single(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RentId)
                .ForeignKey("dbo.Price", t => t.PriceId)
                .ForeignKey("dbo.Room", t => t.RoomId)
                .ForeignKey("dbo.User", t => t.UserId)
                .ForeignKey("dbo.Renter", t => t.RenterId)
                .Index(t => t.RoomId)
                .Index(t => t.RenterId)
                .Index(t => t.UserId)
                .Index(t => t.PriceId);
            
            CreateTable(
                "dbo.Price",
                c => new
                    {
                        PriceId = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        IsNonProfit = c.Boolean(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PriceId)
                .ForeignKey("dbo.Room", t => t.RoomId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        Password = c.String(nullable: false, maxLength: 256, unicode: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Renter", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Rent", "RenterId", "dbo.Renter");
            DropForeignKey("dbo.Rent", "UserId", "dbo.User");
            DropForeignKey("dbo.Renter", "CreatedBy", "dbo.User");
            DropForeignKey("dbo.Rent", "RoomId", "dbo.Room");
            DropForeignKey("dbo.Price", "RoomId", "dbo.Room");
            DropForeignKey("dbo.Rent", "PriceId", "dbo.Price");
            DropIndex("dbo.User", new[] { "PersonId" });
            DropIndex("dbo.Price", new[] { "RoomId" });
            DropIndex("dbo.Rent", new[] { "PriceId" });
            DropIndex("dbo.Rent", new[] { "UserId" });
            DropIndex("dbo.Rent", new[] { "RenterId" });
            DropIndex("dbo.Rent", new[] { "RoomId" });
            DropIndex("dbo.Renter", new[] { "CreatedBy" });
            DropIndex("dbo.Renter", new[] { "PersonId" });
            DropTable("dbo.User");
            DropTable("dbo.Room");
            DropTable("dbo.Price");
            DropTable("dbo.Rent");
            DropTable("dbo.Renter");
            DropTable("dbo.Person");
        }
    }
}
