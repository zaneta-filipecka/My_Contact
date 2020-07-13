using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Contact.Entity
{
    /// <summary>
    /// This is the entity of contact
    /// </summary>
    class Contact
    {
        /// <summary>
        /// int Id property contains id of contact.
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int Id { get; set; }

        /// <summary>
        /// string FirstName property contains first name of contact.
        /// </summary>
        /// <example>
        /// John
        /// </example>
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// string LastName property contains last name of contact. 
        /// </summary>
        /// <example>
        /// Doe
        /// </example>
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// string Address property contains address of contact. 
        /// </summary>
        /// <example>
        /// st. Wall 58
        /// Manchester
        /// </example>
        public string Address { get; set; }

        /// <summary>
        /// string Email property contains email address of contact.
        /// </summary>
        /// <example>
        /// kjarzyna@gmail.com
        /// </example>
        public string Email { get; set; }

        /// <summary>
        /// string Phone property contains phone number of contact. 
        /// </summary>
        /// <example>
        /// +48 556 321 123
        /// </example>
        public string Phone { get; set; }

        /// <summary>
        /// string Company property contains company name of contact. 
        /// </summary>
        /// <example>
        /// My Company :D
        /// </example>
        public string Company { get; set; }
    }
}
