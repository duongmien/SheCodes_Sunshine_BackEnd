//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sunshine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plan
    {
        public int Id { get; set; }
        public int IdPost { get; set; }
        public System.DateTime TimePlan { get; set; }
        public string Purpose { get; set; }
        public decimal Budget { get; set; }
        public string Street { get; set; }
        public int IdWard { get; set; }
        public int IdDistrict { get; set; }
        public int IdCity { get; set; }
    
        public virtual City City { get; set; }
        public virtual District District { get; set; }
        public virtual Post Post { get; set; }
        public virtual Ward Ward { get; set; }
    }
}
