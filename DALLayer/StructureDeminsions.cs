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
    
    public partial class StructureDeminsions
    {
        public long ID { get; set; }
        public Nullable<int> StructureCode { get; set; }
        public Nullable<int> FinCatCode { get; set; }
        public string AccCode { get; set; }
    
        public virtual Accounts Accounts { get; set; }
        public virtual AccountStructure AccountStructure { get; set; }
        public virtual FinancialCategory FinancialCategory { get; set; }
    }
}
