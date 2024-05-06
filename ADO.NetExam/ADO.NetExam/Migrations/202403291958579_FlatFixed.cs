namespace ADO.NetExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FlatFixed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Flats", "Contract_Id", "dbo.Contracts");
            DropIndex("dbo.Flats", new[] { "Contract_Id" });
            RenameColumn(table: "dbo.Flats", name: "Contract_Id", newName: "ContractId");
            AlterColumn("dbo.Flats", "ContractId", c => c.Int(nullable: false));
            CreateIndex("dbo.Flats", "ContractId");
            AddForeignKey("dbo.Flats", "ContractId", "dbo.Contracts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Flats", "ContractId", "dbo.Contracts");
            DropIndex("dbo.Flats", new[] { "ContractId" });
            AlterColumn("dbo.Flats", "ContractId", c => c.Int());
            RenameColumn(table: "dbo.Flats", name: "ContractId", newName: "Contract_Id");
            CreateIndex("dbo.Flats", "Contract_Id");
            AddForeignKey("dbo.Flats", "Contract_Id", "dbo.Contracts", "Id");
        }
    }
}
