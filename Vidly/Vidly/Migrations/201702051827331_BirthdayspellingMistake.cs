namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BirthdayspellingMistake : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthdayDate", c => c.DateTime());
            DropColumn("dbo.Customers", "BrithdayDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BrithdayDate", c => c.DateTime());
            DropColumn("dbo.Customers", "BirthdayDate");
        }
    }
}
