//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DensNDente_Warehouse_Management.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblVendor
    {
        public tblVendor()
        {
            this.tblPurchaseOrders = new HashSet<tblPurchaseOrder>();
            this.tblProductVendorLinks = new HashSet<tblProductVendorLink>();
        }
    
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VendorEmail { get; set; }
        public string VendorPhone { get; set; }
        public string VendorDescription { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<tblPurchaseOrder> tblPurchaseOrders { get; set; }
        public virtual ICollection<tblProductVendorLink> tblProductVendorLinks { get; set; }
    }
}
