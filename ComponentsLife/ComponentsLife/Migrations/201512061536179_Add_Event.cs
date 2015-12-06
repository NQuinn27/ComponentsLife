namespace ComponentsLife.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Event : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        kilometers = c.Int(nullable: false),
                        engine_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Engines", t => t.engine_ID)
                .Index(t => t.engine_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "engine_ID", "dbo.Engines");
            DropIndex("dbo.Events", new[] { "engine_ID" });
            DropTable("dbo.Events");
        }
    }
}
