﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public int DeviceId { get; set; }
        public Nullable<int> BillingPeriodId { get; set; }
        public double TotalUnit { get; set; }
        public double TotalUnitCost { get; set; }
        public double TotalVAT { get; set; }
        public double Surcharge { get; set; }
        public double TotalCost { get; set; }
        public System.DateTime DueDate { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual BillingPeriod BillingPeriod { get; set; }
        public virtual Device Device { get; set; }
    }
}