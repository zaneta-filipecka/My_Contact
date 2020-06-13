namespace My_Contact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateContactColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
        }
    }
}
