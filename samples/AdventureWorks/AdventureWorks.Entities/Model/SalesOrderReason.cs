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
    
    public partial class SalesOrderReason
    {
        public int SalesOrderId { get; set; }
        public int SalesReasonId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual SalesOrder SalesOrderObject { get; set; }
        public virtual SalesReason SalesReasonIdObject { get; set; }
    }
}
