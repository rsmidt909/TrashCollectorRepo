namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.Int(nullable: false),
                        StreetAddress = c.String(),
                        ZipCode = c.Int(nullable: false),
                        SpecificPickUpDate = c.String(),
                        FreezeTimeFrame = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
