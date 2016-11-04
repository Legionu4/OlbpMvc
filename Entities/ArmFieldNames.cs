
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

   
    public partial class ArmFieldNames
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string NumberDocument { get; set; }
        public string DateDocument { get; set; }
        public string AccountNumber { get; set; }
        public string BillNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string Barcode { get; set; }
        public string FIO { get; set; }
        public string Ks { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string Subsidies { get; set; }
        public string ServicePurpose { get; set; }
        public string Additional { get; set; }
        //public int OrganisationFk { get; set; }
        //[ForeignKey("OrganisationFk")]
        //public virtual Organisations Organisations { get; set; }
    }
}
