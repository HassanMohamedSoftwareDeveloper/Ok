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
    
    public partial class UOMCCategory
    {
        public UOMCCategory()
        {
            this.Unit = new HashSet<Unit>();
        }
    
        public int CatCode { get; set; }
        public string CatName { get; set; }
    
        public virtual ICollection<Unit> Unit { get; set; }
    }
}