namespace PersonelApp.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Departments", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Departments", "DeleteDate", c => c.DateTime());
            AddColumn("dbo.Departments", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "IsActive");
            DropColumn("dbo.Departments", "DeleteDate");
            DropColumn("dbo.Departments", "UpdateDate");
            DropColumn("dbo.Departments", "CreatedDate");
        }
    }
}
