using System;
using System.Collections.Generic;

namespace Sakila.Models
{
    public partial class CustomerAddress
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string IsActive { get; set; }
    }
}
