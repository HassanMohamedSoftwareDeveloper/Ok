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
    
    public partial class UOMConversions
    {
        public int ID { get; set; }
        public Nullable<int> Unit_Code_From { get; set; }
        public Nullable<int> Unit_Code_To { get; set; }
        public Nullable<int> ProductCode { get; set; }
        public Nullable<decimal> Factor { get; set; }
        public Nullable<bool> IsSpecial { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Unit Unit1 { get; set; }
    }
}