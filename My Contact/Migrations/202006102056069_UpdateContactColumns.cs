namespace My_Contact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// This Class adds restriction for first name and last name of contact in database table
    /// </summary>
    public partial class UpdateContactColumns : DbMigration
    {
        /// <summary>
        /// Method that add restrictions for FirstName and LastName of contact. 
        /// </summary>
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(maxLength: 50));
        }

        /// <summary>
        /// Method that removes restrictions from FirstName and LastName of contact. 
        /// </summary>
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
        }
    }
}
