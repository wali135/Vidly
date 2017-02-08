namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3a66bf03-b57f-4ce6-8913-0f1ca3fb3068', N'admin@vidly.com', 0, N'AP38lx8BRRNWzQHV4HUl2FO0eVKhe9uuleIYHhprRq1eBpdBwI+YF8nnHyjQUmWyGQ==', N'49dd13f2-8c70-407c-b006-a845f19eec6f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8677c402-6947-4d12-b686-11a61c9c1eef', N'guest@vidly.com', 0, N'AM+lF4OdOrPWnDcV98tkatQ1xpeFbLYtWizJjabneL0P0TL4UUHYfJa0I9nHJgxtQQ==', N'3340a944-63e3-4f92-a8b5-0ffe5afc9114', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ce18760a-a8a7-4107-81a6-66f47022f137', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3a66bf03-b57f-4ce6-8913-0f1ca3fb3068', N'ce18760a-a8a7-4107-81a6-66f47022f137')

");
        }
        
        public override void Down()
        {
        }
    }
}
