using System;
using System.Collections.Generic;

namespace Sakila.Models
{
    public partial class TopSellingRRatedFilms
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public decimal? RentalSales { get; set; }
        public short? Length { get; set; }
    }
}
