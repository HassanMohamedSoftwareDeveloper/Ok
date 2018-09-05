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
    
    public partial class Product
    {
        public Product()
        {
            this.Expired_Date = new HashSet<Expired_Date>();
            this.OfferedProducts = new HashSet<OfferedProducts>();
            this.ProductOnHand = new HashSet<ProductOnHand>();
            this.PurchaseDetails = new HashSet<PurchaseDetails>();
            this.SalesDetails = new HashSet<SalesDetails>();
            this.UOMConversions = new HashSet<UOMConversions>();
            this.BOMIngredientsProducts = new HashSet<BOMIngredientsProducts>();
            this.BOMOutputProduct = new HashSet<BOMOutputProduct>();
        }
    
        public int Product_Code { get; set; }
        public string Product_Name { get; set; }
        public string ProductDesc { get; set; }
        public string SearchName { get; set; }
        public byte[] Product_Image { get; set; }
        public string Product_Barcode { get; set; }
        public Nullable<int> DefPurchaseWH { get; set; }
        public Nullable<int> DefSalesWH { get; set; }
        public Nullable<int> DefInventoryUnit { get; set; }
        public Nullable<int> DefPurchaseUnit { get; set; }
        public Nullable<int> DefSalesUnit { get; set; }
        public Nullable<decimal> DefSalesPrice { get; set; }
        public Nullable<decimal> DefPurchasePrice { get; set; }
        public string ProductType { get; set; }
        public Nullable<int> GroupCode { get; set; }
    
        public virtual ICollection<Expired_Date> Expired_Date { get; set; }
        public virtual ICollection<OfferedProducts> OfferedProducts { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Unit Unit1 { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        public virtual Unit Unit2 { get; set; }
        public virtual WareHouse WareHouse1 { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<ProductOnHand> ProductOnHand { get; set; }
        public virtual ICollection<PurchaseDetails> PurchaseDetails { get; set; }
        public virtual ICollection<SalesDetails> SalesDetails { get; set; }
        public virtual ICollection<UOMConversions> UOMConversions { get; set; }
        public virtual ICollection<BOMIngredientsProducts> BOMIngredientsProducts { get; set; }
        public virtual ICollection<BOMOutputProduct> BOMOutputProduct { get; set; }
    }
}