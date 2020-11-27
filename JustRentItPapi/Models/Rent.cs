using System;
using System.Collections.Generic;

#nullable disable

namespace JustRentItPapi.Models
{
    public partial class Rent
    {
        public string Id { get; set; }
        public string Rentperiod { get; set; }
        public int? Price { get; set; }
        public string Confirmation { get; set; }
    }
}
