namespace My_Contact.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using My_Contact.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<My_Contact.DAL.MyContactContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(My_Contact.DAL.MyContactContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact { FirstName = "Krzysztof", LastName = "Jarzyna", Address = "Szczecin", Email = "kjarzyna@gmail.com", Company = "Krzys", Phone = "456456456" }
            };

            contacts.ForEach(c => context.Contacts.AddOrUpdate(p => p.LastName, c));
            context.SaveChanges();
        }
    }
}
