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
    
    public partial class WorkOrder
    {
        public int WorkOrderId { get; set; }
        public int OrderQty { get; set; }
        public int StockedQty { get; set; }
        public short ScrappedQty { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Product ProductIdObject { get; set; }
        public virtual ScrapReason ScrapReasonIdObject { get; set; }
    }
}
