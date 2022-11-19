namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adminUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'023379eb-a878-495d-8815-a4e9ef75845c', N'guest@gmail.com', 0, N'AGHyN1T5clbF1Rwoc1fn2OvoXC9gbEHjk5V7DCPSAXDcFlYM3PS3I97gxzJgHZov4g==', N'10bb59e2-950e-49b0-b626-e1e8be27498d', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'417d779f-62b1-4cc8-b886-408ff3e603e1', N'0SouHaib0@gmail.com', 0, N'ALZWh4VxbtvuaKDAlM3r6MjmJ3BVHLaFnto0Y38SGLoHZ+FNrcZcNT6KW+d6xBeymw==', N'1e4bcf33-d96e-45ba-85d5-c5dfb16f72bd', NULL, 0, 0, NULL, 1, 0, N'0SouHaib0@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7ba40473-57fc-4e31-b3ad-1db85a7cfcf7', N'MovieManager')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'417d779f-62b1-4cc8-b886-408ff3e603e1', N'7ba40473-57fc-4e31-b3ad-1db85a7cfcf7')

");

        }
        
        public override void Down()
        {
        }
    }
}
