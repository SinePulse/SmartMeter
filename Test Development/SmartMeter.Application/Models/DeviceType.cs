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
    
    public partial class DeviceType
    {
        public DeviceType()
        {
            this.CommandValues = new HashSet<CommandValue>();
            this.Devices = new HashSet<Device>();
            this.DeviceTypeProperties = new HashSet<DeviceTypeProperty>();
        }
    
        public int DeviceTypeId { get; set; }
        public string DeviceTypeName { get; set; }
        public string DeviceTypeDecription { get; set; }
    
        public virtual ICollection<CommandValue> CommandValues { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<DeviceTypeProperty> DeviceTypeProperties { get; set; }
    }
}
