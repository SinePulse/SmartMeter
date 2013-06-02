﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public partial class Device
    {
        //public Device()
        //{
        //    this.Bills = new HashSet<Bill>();
        //    this.Device1 = new HashSet<Device>();
        //    this.DeviceProperties = new HashSet<DeviceProperty>();
        //    this.MeterProperties = new HashSet<MeterProperty>();
        //}

        public int DeviceId { get; set; }
        public int DeviceTypeId { get; set; }
        public string HardwareId { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
        public Nullable<int> ParentDeviceId { get; set; }
        public Nullable<int> NumberOfSubDevice { get; set; }
        public bool Status { get; set; }
        public int BillSchemeId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual AppUser AppUser2 { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual BillScheme BillScheme { get; set; }
        public virtual DeviceType DeviceType { get; set; }
        public virtual ICollection<Device> Device1 { get; set; }
        public virtual Device Device2 { get; set; }
        public virtual ICollection<DeviceProperty> DeviceProperties { get; set; }
        public virtual ICollection<MeterProperty> MeterProperties { get; set; }
    }
}
