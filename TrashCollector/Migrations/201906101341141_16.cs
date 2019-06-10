namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _16 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Latitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Customers", "Longitude", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Longitude", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Latitude", c => c.Int(nullable: false));
        }
    }
}
