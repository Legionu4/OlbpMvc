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

    public partial class ExternalService
    {
        public ExternalService()
        {
            this.ExtServiceUser = new HashSet<ExtServiceUser>();
        }
        [Key]
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string DllGuidId { get; set; }
        public string ServiceName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public Nullable<bool> IsCertificateUsing { get; set; }
        public string CertificatePassword { get; set; }
        public string ServiceCertificate { get; set; }
        public Nullable<bool> IsUsingProxy { get; set; }
        public string ProxyAddress { get; set; }
        public Nullable<int> ProxyPort { get; set; }
        public string SSLProtocolType { get; set; }
        public string ProxyLogin { get; set; }
        public string ProxyPassword { get; set; }
        public Nullable<int> TimeOut { get; set; }

        public virtual ICollection<ExtServiceUser> ExtServiceUser { get; set; }
    }
}
