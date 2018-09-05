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
    
    public partial class BOMIngredientsProducts
    {
        public long IngCode { get; set; }
        public string LookUpCode { get; set; }
        public long OutputCode { get; set; }
        public long BOMCode { get; set; }
        public Nullable<int> ProductCode { get; set; }
        public Nullable<int> WHCode { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> Quantity { get; set; }
    
        public virtual BOMHeader BOMHeader { get; set; }
        public virtual BOMOutputProduct BOMOutputProduct { get; set; }
        public virtual Product Product { get; set; }
        public virtual WareHouse WareHouse { get; set; }
    }
}