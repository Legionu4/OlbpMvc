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
    
    public partial class Terminals
    {
        public Terminals()
        {
            this.terminal_payments = new HashSet<TerminalPayments>();
        }
    
        public int id { get; set; }
        public int index_id { get; set; }
        public string name { get; set; }
        public short is_archive { get; set; }
        public int number_of_banknotes { get; set; }
        public int max_number_of_banknotes { get; set; }
    
        public virtual Indexes indexes { get; set; }
        public virtual ICollection<TerminalPayments> terminal_payments { get; set; }
    }
}