//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReestrsTemplates
    {
        public int Id { get; set; }
        [ Key,ForeignKey("Organisations")]
        public int OrgId { get; set; }
        public int grouping_type_id { get; set; }
        public int numeration_type_id { get; set; }
        public int reestr_type_id { get; set; }
        public byte[] template { get; set; }
    
        public virtual DescriptionIds description_ids { get; set; }
        public virtual DescriptionIds description_ids1 { get; set; }
        public virtual DescriptionIds description_ids2 { get; set; }
       
        public virtual Organisations Organisations { get; set; }
    }
}
