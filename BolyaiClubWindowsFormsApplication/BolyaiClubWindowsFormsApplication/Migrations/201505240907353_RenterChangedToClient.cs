namespace BolyaiClubWindowsFormsApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenterChangedToClient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Renter", "CreatedBy", "dbo.User");
            DropForeignKey("dbo.Rent", "RenterId", "dbo.Renter");
            DropForeignKey("dbo.Renter", "PersonId", "dbo.Person");
            DropIndex("dbo.Rent", new[] { "RenterId" });
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        IsNonProfit = c.Boolean(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .ForeignKey("dbo.User", t => t.CreatedBy);
            
            AddColumn("dbo.Rent", "ClientId", c => c.Int(nullable: false));
            CreateIndex("dbo.Rent", "ClientId");
            AddForeignKey("dbo.Rent", "ClientId", "dbo.Client", "ClientId");
            DropColumn("dbo.Rent", "RenterId");
            DropTable("dbo.Renter");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.RenterId);
            
            AddColumn("dbo.Rent", "RenterId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Rent", "ClientId", "dbo.Renter");
            DropForeignKey("dbo.Renter", "CreatedBy", "dbo.User");
            DropForeignKey("dbo.Renter", "PersonId", "dbo.Person");
            DropIndex("dbo.Rent", new[] { "ClientId" });
            DropColumn("dbo.Rent", "ClientId");
            DropTable("dbo.Renter");
            CreateIndex("dbo.Rent", "RenterId");
            AddForeignKey("dbo.Renter", "PersonId", "dbo.Person", "PersonId");
            AddForeignKey("dbo.Rent", "RenterId", "dbo.Renter", "RenterId");
            AddForeignKey("dbo.Renter", "CreatedBy", "dbo.User", "UserId");
        }
    }
}
