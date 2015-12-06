namespace ComponentsLife.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_ck : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Brakes", "currentKilometers");
            DropColumn("dbo.Drivetrains", "currentKilometers");
            DropColumn("dbo.Engines", "currentKilometers");
            DropColumn("dbo.Suspensions", "currentKilometers");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Suspensions", "currentKilometers", c => c.Int(nullable: false));
            AddColumn("dbo.Engines", "currentKilometers", c => c.Int(nullable: false));
            AddColumn("dbo.Drivetrains", "currentKilometers", c => c.Int(nullable: false));
            AddColumn("dbo.Brakes", "currentKilometers", c => c.Int(nullable: false));
        }
    }
}
