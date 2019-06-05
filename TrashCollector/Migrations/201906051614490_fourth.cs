namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Lastname", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Lastname", c => c.Int(nullable: false));
        }
    }
}
