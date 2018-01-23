namespace ListFolder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Project_Address_AddTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Address", c => c.String());
            AddColumn("dbo.Projects", "AddTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "AddTime");
            DropColumn("dbo.Projects", "Address");
        }
    }
}
