//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDACTP034150.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CargoBooking
    {
        public int BookingId { get; set; }
        public string AgentEmail { get; set; }
        public Nullable<int> CargoId { get; set; }
        public Nullable<System.DateTime> DepartDate { get; set; }
        public Nullable<int> shiptranId { get; set; }
    
        public virtual Cargo Cargo { get; set; }
        public virtual Shiptransaction Shiptransaction { get; set; }
    }
}
