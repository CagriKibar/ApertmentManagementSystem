namespace Manager.Core.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mi_remove_item : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Events", "ThemeColor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "ThemeColor", c => c.String());
        }
    }
}
