namespace My_Contact.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    //! This class creates Contact table in database 
    public partial class CreateContact : DbMigration
    {
        /**
         * Method that creates Contacts table in database. 
         */
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

        /**
         * Method that removes Contacts table from database. 
         */
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
