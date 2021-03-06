//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Districts
    {
        public Districts()
        {
            this.AbrilBarcodesetting = new HashSet<AbrilBarcodesetting>();
            this.Pl_City = new HashSet<PlCity>();
        }
    
        [Key]
        public int Id { get; set; }      
        public double DistrictId { get; set; }
        public string DistrictName { get; set; }
        public double RegionId { get; set; }
        public Nullable<int> OrgIdfl { get; set; }
    
        public virtual ICollection<AbrilBarcodesetting> AbrilBarcodesetting { get; set; }
        public virtual Regions Regions { get; set; }
        public virtual ICollection<PlCity> Pl_City { get; set; }
    }
}
