namespace ADO.NetExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContractFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Flats", "ContractId", "dbo.Contracts");
            DropIndex("dbo.Flats", new[] { "ContractId" });
            AlterColumn("dbo.Flats", "ContractId", c => c.Int());
            CreateIndex("dbo.Flats", "ContractId");
            AddForeignKey("dbo.Flats", "ContractId", "dbo.Contracts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Flats", "ContractId", "dbo.Contracts");
            DropIndex("dbo.Flats", new[] { "ContractId" });
            AlterColumn("dbo.Flats", "ContractId", c => c.Int(nullable: false));
            CreateIndex("dbo.Flats", "ContractId");
            AddForeignKey("dbo.Flats", "ContractId", "dbo.Contracts", "Id", cascadeDelete: true);
        }
    }
}
