namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembership : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes set name='Pay as you go' where id=1 ");
            Sql("UPDATE MemberShipTypes set name='Monthly' where id=2 ");
            Sql("UPDATE MemberShipTypes set name='Semi-annual' where id=3 ");
            Sql("UPDATE MemberShipTypes set name='Yearly' where id=4 ");
        }
        
        public override void Down()
        {
        }
    }
}
