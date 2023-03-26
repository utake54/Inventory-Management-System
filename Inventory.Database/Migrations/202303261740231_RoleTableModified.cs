namespace Inventory.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleTableModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoleMasters", "RoleName", c => c.String());
            AddColumn("dbo.Users", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "RegisteredDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.RoleMasters", "UserRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RoleMasters", "UserRole", c => c.String());
            DropColumn("dbo.Users", "RegisteredDate");
            DropColumn("dbo.Users", "IsActive");
            DropColumn("dbo.RoleMasters", "RoleName");
        }
    }
}
