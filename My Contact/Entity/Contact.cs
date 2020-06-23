using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Contact.Entity
{
    //! This is the entity of contact
    class Contact
    {
        /**
         * int Id variable contains id of contact. 
         */
        public int Id { get; set; }

        /**
         * string FirstName variable contains first name of contact. 
         */
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        /**
         * string LastName variable contains last name of contact. 
         */
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        /**
         * string Address variable contains address of contact. 
         */
        public string Address { get; set; }

        /**
         * string Email variable contains email address of contact. 
         */
        public string Email { get; set; }

        /**
         * string Phone variable contains phone number of contact. 
         */
        public string Phone { get; set; }

        /**
         * string Company variable contains company name of contact. 
         */
        public string Company { get; set; }
    }
}
