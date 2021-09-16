namespace Manager.Core.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_manager_adminAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppManagers", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppManagers", "IsAdmin");
        }
    }
}
