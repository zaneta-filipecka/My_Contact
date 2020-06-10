using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Contact.Entity;

namespace My_Contact.DAL
{
    class MyContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
