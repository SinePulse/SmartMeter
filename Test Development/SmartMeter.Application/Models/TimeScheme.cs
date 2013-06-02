//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartMeter.Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeScheme
    {
        public TimeScheme()
        {
            this.BillingRateConfigs = new HashSet<BillingRateConfig>();
        }
    
        public int TimeSchemeId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string TimeSchemeName { get; set; }
        public string TimeSchemeDescription { get; set; }
        public System.DateTime StartsAt { get; set; }
        public System.DateTime EndsAt { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
    
        public virtual ICollection<BillingRateConfig> BillingRateConfigs { get; set; }
        public virtual Company Company { get; set; }
    }
}
