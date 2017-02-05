namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBirthdayToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BrithdayDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BrithdayDate");
        }
    }
}
