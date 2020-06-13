using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Contact.Entity
{
    class Contact
    {
        public int Id { get; set; }
        
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
    }
}
