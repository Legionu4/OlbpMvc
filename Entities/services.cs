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
    
    public partial class Services
    {
        public Services()
        {
            this.plat_templates = new HashSet<PlatTemplates>();
            this.rpayer_links = new HashSet<RpayerLinks>();
            this.localisation_to_city = new HashSet<LocalisationToCity>();
            this.payment_barcodes = new HashSet<PaymentBarcodes>();
            this.services_to_city = new HashSet<ServicesToCity>();
            this.templates = new HashSet<Templates>();
            this.UserToSpeedCodes = new HashSet<UserToSpeedCodes>();
        }
    
        public int id { get; set; }
        public Nullable<int> orgid { get; set; }
        public string name { get; set; }
        public Nullable<bool> useorgfinprops { get; set; }
        public string account { get; set; }
        public string mfo { get; set; }
        public string bankname { get; set; }
        public Nullable<short> tarif { get; set; }
        public Nullable<double> percent { get; set; }
        public Nullable<double> minsum { get; set; }
        public string nomenklature { get; set; }
        public Nullable<bool> isarchive { get; set; }
        public string code { get; set; }
        public int location_id { get; set; }
        public string edrpou { get; set; }
    
        public virtual DescriptionIds description_ids { get; set; }
        public virtual Organisations organisations { get; set; }
        public virtual ICollection<PlatTemplates> plat_templates { get; set; }
        public virtual ICollection<RpayerLinks> rpayer_links { get; set; }
        public virtual ICollection<LocalisationToCity> localisation_to_city { get; set; }
        public virtual ICollection<PaymentBarcodes> payment_barcodes { get; set; }
        public virtual Tarifs tarifs { get; set; }
        public virtual ICollection<ServicesToCity> services_to_city { get; set; }
        public virtual ICollection<Templates> templates { get; set; }
        public virtual ICollection<UserToSpeedCodes> UserToSpeedCodes { get; set; }
    }
}