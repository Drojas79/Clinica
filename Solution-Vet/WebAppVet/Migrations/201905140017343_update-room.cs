namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateroom : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "Name", c => c.String());
            AlterColumn("dbo.Rooms", "Location", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "Location", c => c.Int(nullable: false));
            AlterColumn("dbo.Rooms", "Name", c => c.Int(nullable: false));
        }
    }
}
