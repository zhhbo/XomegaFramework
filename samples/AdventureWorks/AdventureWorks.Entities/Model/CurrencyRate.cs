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
    
    public partial class CurrencyRate
    {
        public int CurrencyRateId { get; set; }
        public System.DateTime CurrencyRateDate { get; set; }
        public decimal AverageRate { get; set; }
        public decimal EndOfDayRate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Currency FromCurrencyCodeObject { get; set; }
        public virtual Currency ToCurrencyCodeObject { get; set; }
    }
}
