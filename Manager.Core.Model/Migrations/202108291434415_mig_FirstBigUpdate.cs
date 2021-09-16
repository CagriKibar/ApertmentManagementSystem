namespace Manager.Core.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_FirstBigUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Citizens", "EventID", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "IsPayment", c => c.Boolean(nullable: false));
            DropColumn("dbo.Events", "Subject");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Subject", c => c.String());
            DropColumn("dbo.Events", "IsPayment");
            DropColumn("dbo.Citizens", "EventID");
        }
    }
}
