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
    
    public partial class Users
    {
        public Users()
        {
            this.extusertoolbpuser = new HashSet<ExtUserToOlbpUser>();
            this.report_defaults = new HashSet<ReportDefaults>();
            this.userstoservicegroups = new HashSet<UsersToServiceGroups>();
            this.user_to_index = new HashSet<UserToIndex>();
            this.UserToSpeedCodes = new HashSet<UserToSpeedCodes>();
        }

        public int Id { get; set; }
        public string pkid { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool isapproved { get; set; }
        public Nullable<System.DateTime> lastlogindate { get; set; }
        public System.DateTime creationdate { get; set; }
        public string userfio { get; set; }
        public string indexvz { get; set; }
        public string role { get; set; }
        public string dsn { get; set; }
        public string parent_pkid { get; set; }
        public int payment_dates { get; set; }
        public short is_in_reports { get; set; }
        public short is_single_folder { get; set; }
    
        public virtual DescriptionIds description_ids { get; set; }
        public virtual ICollection<ExtUserToOlbpUser> extusertoolbpuser { get; set; }
        public virtual FinanceSetttings finance_setttings { get; set; }
        public virtual ICollection<ReportDefaults> report_defaults { get; set; }
        public virtual ICollection<UsersToServiceGroups> userstoservicegroups { get; set; }
        public virtual ICollection<UserToIndex> user_to_index { get; set; }
        public virtual ICollection<UserToSpeedCodes> UserToSpeedCodes { get; set; }
    }
}