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
    
    public partial class User
    {
        public User()
        {
            this.PostedTransactions = new HashSet<PostedTransactions>();
            this.PurchaseHeader = new HashSet<PurchaseHeader>();
            this.SalesHeader = new HashSet<SalesHeader>();
            this.TransactionHeader = new HashSet<TransactionHeader>();
            this.UserRoles = new HashSet<UserRoles>();
            this.BOMHeader = new HashSet<BOMHeader>();
        }
    
        public int User_Code { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public Nullable<int> Employee_Code { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<PostedTransactions> PostedTransactions { get; set; }
        public virtual ICollection<PurchaseHeader> PurchaseHeader { get; set; }
        public virtual ICollection<SalesHeader> SalesHeader { get; set; }
        public virtual ICollection<TransactionHeader> TransactionHeader { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<BOMHeader> BOMHeader { get; set; }
    }
}
