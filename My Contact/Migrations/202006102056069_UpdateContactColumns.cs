namespace My_Contact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    //! This Class adds restriction for first name and last name of contact in database table
    public partial class UpdateContactColumns : DbMigration
    {
        /**
         * Method that add restrictions for FirstName and LastName of contact. 
         */
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(maxLength: 50));
        }

        /**
         * Method that removes restrictions from FirstName and LastName of contact. 
         */
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
        }
    }
}
