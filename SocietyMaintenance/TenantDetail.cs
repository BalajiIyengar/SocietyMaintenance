//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocietyMaintenance
{
    using System;
    using System.Collections.Generic;
    
    public partial class TenantDetail
    {
        public long TenantId { get; set; }
        public string TenantName { get; set; }
        public long FlatNumber { get; set; }
        public string TenantAddress { get; set; }
        public string TenantEmailId { get; set; }
        public string TenantPhoneNumber { get; set; }
        public long TenantFamilyCount { get; set; }
        public bool isActive { get; set; }
        public string VehicleNumbers { get; set; }
    
        public virtual TenantDetail TenantDetails1 { get; set; }
        public virtual TenantDetail TenantDetail1 { get; set; }
    }
}
