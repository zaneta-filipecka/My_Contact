namespace My_Contact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// This class creates Contact table in database 
    /// </summary>
    public partial class CreateContact : DbMigration
    {
        /// <summary>
        /// Method that creates Contacts table in database. 
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }

        /// <summary>
        /// Method that removes Contacts table from database. 
        /// </summary>
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
