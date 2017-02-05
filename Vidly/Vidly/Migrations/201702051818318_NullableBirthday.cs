namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableBirthday : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BrithdayDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BrithdayDate", c => c.DateTime(nullable: false));
        }
    }
}
