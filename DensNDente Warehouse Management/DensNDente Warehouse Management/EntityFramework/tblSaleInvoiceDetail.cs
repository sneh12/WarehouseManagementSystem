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
    
    public partial class tblSaleInvoiceDetail
    {
        public int InvoiceDetailId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public bool Deleted { get; set; }
    
        public virtual tblProduct tblProduct { get; set; }
        public virtual tblSaleInvoice tblSaleInvoice { get; set; }
    }
}
