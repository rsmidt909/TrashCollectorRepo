namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "WeeklyPickUpDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "WeeklyPickUpDate");
        }
    }
}
