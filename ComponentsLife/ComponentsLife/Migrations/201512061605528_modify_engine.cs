namespace ComponentsLife.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modify_engine : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "engine_ID", "dbo.Engines");
            DropIndex("dbo.Events", new[] { "engine_ID" });
            AddColumn("dbo.Events", "engineId", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "drivetrainId", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "suspensionId", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "brakesId", c => c.Int(nullable: false));
            DropColumn("dbo.Events", "engine_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "engine_ID", c => c.Int());
            DropColumn("dbo.Events", "brakesId");
            DropColumn("dbo.Events", "suspensionId");
            DropColumn("dbo.Events", "drivetrainId");
            DropColumn("dbo.Events", "engineId");
            CreateIndex("dbo.Events", "engine_ID");
            AddForeignKey("dbo.Events", "engine_ID", "dbo.Engines", "ID");
        }
    }
}
