namespace PersonelApp.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        Personel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personels", t => t.Personel_Id)
                .Index(t => t.Personel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "Personel_Id", "dbo.Personels");
            DropIndex("dbo.Personels", new[] { "Personel_Id" });
            DropTable("dbo.Personels");
            DropTable("dbo.Departments");
        }
    }
}
