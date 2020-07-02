using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Contact.Entity;

namespace My_Contact.DAL
{
    //! This class alows to connect with database
    class MyContactContext : DbContext
    {
        /**
         * This is the database handler that alows to connect with Contacts table in database. 
         */
        public DbSet<Contact> Contacts { get; set; }
    }
}
