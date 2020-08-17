using System;
using System.Collections.Generic;

namespace Sakila.Models
{
    public partial class BestSellingActors
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? RentalSales { get; set; }
    }
}
