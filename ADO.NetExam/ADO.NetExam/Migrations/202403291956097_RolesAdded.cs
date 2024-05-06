namespace ADO.NetExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolesAdded : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Users");
            RenameColumn(table: "dbo.Contracts", name: "CustomerId", newName: "UserId");
            RenameIndex(table: "dbo.Contracts", name: "IX_CustomerId", newName: "IX_UserId");
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "RoleId");
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropColumn("dbo.Users", "RoleId");
            DropTable("dbo.Roles");
            RenameIndex(table: "dbo.Contracts", name: "IX_UserId", newName: "IX_CustomerId");
            RenameColumn(table: "dbo.Contracts", name: "UserId", newName: "CustomerId");
            RenameTable(name: "dbo.Users", newName: "Customers");
        }
    }
}
