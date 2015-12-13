namespace ComponentsLife.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Date_ofBirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RegistrationDate", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "ProfileImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "ProfileImage", c => c.Binary());
            DropColumn("dbo.AspNetUsers", "RegistrationDate");
        }
    }
}
