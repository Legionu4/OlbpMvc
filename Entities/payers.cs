//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payers
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Korpus { get; set; }
        public string Apartment { get; set; }
        public string Identifier { get; set; }
        public Nullable<double> StreetId { get; set; }
        public Nullable<double> BuildingId { get; set; }
        public string Passport { get; set; }
        public string TelephonNumber { get; set; }
        public Nullable<double> CityId { get; set; }
    }
}
