namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembership : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee ,DurationInMonth,DiscounteRate) VALUES (1,0,0,0)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee ,DurationInMonth,DiscounteRate) VALUES (2,30,1,10)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee ,DurationInMonth,DiscounteRate) VALUES (3,90,3,15)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee ,DurationInMonth,DiscounteRate) VALUES (4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
