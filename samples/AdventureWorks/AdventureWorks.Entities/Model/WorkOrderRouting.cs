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
    
    public partial class WorkOrderRouting
    {
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public short OperationSequence { get; set; }
        public System.DateTime ScheduledStartDate { get; set; }
        public System.DateTime ScheduledEndDate { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public Nullable<decimal> ActualResourceHrs { get; set; }
        public decimal PlannedCost { get; set; }
        public Nullable<decimal> ActualCost { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Location LocationIdObject { get; set; }
        public virtual WorkOrder WorkOrderIdObject { get; set; }
    }
}
