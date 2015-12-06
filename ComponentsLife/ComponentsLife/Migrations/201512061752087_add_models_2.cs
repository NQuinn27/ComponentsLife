namespace ComponentsLife.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_models_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brakes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        notes = c.String(),
                        currentKilometers = c.Int(nullable: false),
                        maxKilometers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Drivetrains",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        notes = c.String(),
                        currentKilometers = c.Int(nullable: false),
                        maxKilometers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Suspensions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        notes = c.String(),
                        currentKilometers = c.Int(nullable: false),
                        maxKilometers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suspensions");
            DropTable("dbo.Drivetrains");
            DropTable("dbo.Brakes");
        }
    }
}
