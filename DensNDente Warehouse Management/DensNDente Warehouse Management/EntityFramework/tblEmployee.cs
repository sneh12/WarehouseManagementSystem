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
    
    public partial class tblEmployee
    {
        public tblEmployee()
        {
            this.tblSalaries = new HashSet<tblSalary>();
        }
    
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string SINNo { get; set; }
        public double PayPerHour { get; set; }
        public int RollId { get; set; }
        public bool Deleted { get; set; }
        public string Password { get; set; }
    
        public virtual tblRole tblRole { get; set; }
        public virtual ICollection<tblSalary> tblSalaries { get; set; }
    }
}
