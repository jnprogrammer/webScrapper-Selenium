namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMembershipTitleToDb : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipTitle = 'Not a Member' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET MembershipTitle = 'Ascended Member' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET MembershipTitle = 'Super Member 3' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET MembershipTitle = 'Mega Member' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
