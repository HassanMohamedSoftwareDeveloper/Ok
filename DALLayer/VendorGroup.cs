//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class VendorGroup
    {
        public VendorGroup()
        {
            this.Vendor = new HashSet<Vendor>();
        }
    
        public int GroupCode { get; set; }
        public string GroupName { get; set; }
    
        public virtual ICollection<Vendor> Vendor { get; set; }
        public virtual VendorPosting VendorPosting { get; set; }
    }
}
