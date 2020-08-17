using System;
using System.Collections.Generic;

namespace Sakila.Models
{
    public partial class RentalsByActor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? TotalViews { get; set; }
    }
}
