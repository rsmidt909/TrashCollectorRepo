namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FreezeTimeFrameStart", c => c.String());
            AddColumn("dbo.Customers", "FreezeTimeFrameEnd", c => c.String());
            AddColumn("dbo.Customers", "Balance", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "State", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            DropColumn("dbo.Customers", "FreezeTimeFrame");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "FreezeTimeFrame", c => c.String());
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "State");
            DropColumn("dbo.Customers", "Balance");
            DropColumn("dbo.Customers", "FreezeTimeFrameEnd");
            DropColumn("dbo.Customers", "FreezeTimeFrameStart");
        }
    }
}
