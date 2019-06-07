namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "FreezeTimeFrameStart", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "FreezeTimeFrameEnd", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "FreezeTimeFrameEnd", c => c.String());
            AlterColumn("dbo.Customers", "FreezeTimeFrameStart", c => c.String());
        }
    }
}
