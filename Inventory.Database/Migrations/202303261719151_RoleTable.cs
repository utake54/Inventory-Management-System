namespace Inventory.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoleMasters",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        UserRole = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoleMasters");
        }
    }
}
