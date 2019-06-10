namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "HouseNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "StreetName", c => c.String());
            DropColumn("dbo.Customers", "StreetAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "StreetAddress", c => c.String());
            DropColumn("dbo.Customers", "StreetName");
            DropColumn("dbo.Customers", "HouseNumber");
        }
    }
}
