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
    
    public partial class FilesStatsTmp
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string FileName { get; set; }
        public Nullable<int> FileSize { get; set; }
        public string UserLogin { get; set; }
        public string UserFio { get; set; }
        public System.DateTime TimeStart { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
        public int CountRows { get; set; }
        public short HasErrors { get; set; }
        public string TemplateName { get; set; }
        public Nullable<int> TemplateTypeId { get; set; }
        public Nullable<double> PaymentSum { get; set; }
        public Nullable<int> ReestrNumber { get; set; }
        public Nullable<int> NumPlat { get; set; }
        public Nullable<System.DateTime> DatePlat { get; set; }
        public Nullable<System.DateTime> PaymStart { get; set; }
        public Nullable<System.DateTime> PaymEnd { get; set; }
        public int IsArchive { get; set; }
        public string GroupParam { get; set; }
    }
}
