namespace ADO.NetExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContractFix2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contracts", "OrderNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contracts", "OrderNumber", c => c.Int(nullable: false));
        }
    }
}
