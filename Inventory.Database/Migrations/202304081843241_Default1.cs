namespace Inventory.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Default1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.RoleMasters");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RoleMasters",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
    }
}
