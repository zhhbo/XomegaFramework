//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorks.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesPersonQuotaHistory
    {
        public int BusinessEntityId { get; set; }
        public System.DateTime QuotaDate { get; set; }
        public decimal SalesQuota { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual SalesPerson BusinessEntityIdObject { get; set; }
    }
}
