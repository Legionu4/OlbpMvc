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

    public partial class DescriptionIds
    {
        public DescriptionIds()
        {
            //this.ArmFieldConfigs = new HashSet<ArmFieldConfigs>();
            this.Planner_Configs = new HashSet<PlannerConfigs>();
            this.description_ids1 = new HashSet<DescriptionIds>();
            this.planner_log = new HashSet<PlannerLog>();
            this.users = new HashSet<Users>();
            this.reestrs_templates = new HashSet<ReestrsTemplates>();
            this.finance_setttings = new HashSet<FinanceSetttings>();
            this.services = new HashSet<Services>();
            this.reestrs_templates1 = new HashSet<ReestrsTemplates>();
            //this.organisations = new HashSet<Organisations>();
            //this.organisations1 = new HashSet<Organisations>();
            //this.organisations2 = new HashSet<Organisations>();
            //this.organisations3 = new HashSet<Organisations>();
            this.payment_barcodes = new HashSet<PaymentBarcodes>();
            this.planner_configs1 = new HashSet<PlannerConfigs>();
            //this.organisations4 = new HashSet<Organisations>();
            this.reestrs_templates2 = new HashSet<ReestrsTemplates>();
            this.report_defaults = new HashSet<ReportDefaults>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public int Type_Id { get; set; }
        public string Value { get; set; }

        public virtual ICollection<ArmFieldConfigs> ArmFieldConfigs { get; set; }
        public virtual ICollection<PlannerConfigs> Planner_Configs { get; set; }
        public virtual ICollection<DescriptionIds> description_ids1 { get; set; }
        public virtual DescriptionIds description_ids2 { get; set; }
        public virtual ICollection<PlannerLog> planner_log { get; set; }
        public virtual ICollection<Users> users { get; set; }
        public virtual ICollection<ReestrsTemplates> reestrs_templates { get; set; }
        public virtual ICollection<FinanceSetttings> finance_setttings { get; set; }
        public virtual ICollection<Services> services { get; set; }
        public virtual ICollection<ReestrsTemplates> reestrs_templates1 { get; set; }
        //public virtual ICollection<Organisations> organisations { get; set; }
        //public virtual ICollection<Organisations> organisations1 { get; set; }
        //public virtual ICollection<Organisations> organisations2 { get; set; }
        //public virtual ICollection<Organisations> organisations3 { get; set; }
        public virtual ICollection<PaymentBarcodes> payment_barcodes { get; set; }
        public virtual ICollection<PlannerConfigs> planner_configs1 { get; set; }
        //public virtual ICollection<Organisations> organisations4 { get; set; }
        public virtual ICollection<ReestrsTemplates> reestrs_templates2 { get; set; }
        public virtual ICollection<ReportDefaults> report_defaults { get; set; }
    }
}