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
    
    public partial class PlannerLog
    {
        public int Id { get; set; }
        public Nullable<int> org_id { get; set; }
        public System.DateTime start_time { get; set; }
        public System.DateTime end_time { get; set; }
        public int action_id { get; set; }
        public string log_message { get; set; }
        public string log_file { get; set; }
    
        public virtual DescriptionIds description_ids { get; set; }
        public virtual Organisations organisations { get; set; }
    }
}
