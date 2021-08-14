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
    
    public partial class Post
    {
        public Post()
        {
            this.Images = new HashSet<Image>();
            this.Plans = new HashSet<Plan>();
        }
    
        public int Id { get; set; }
        public System.DateTime TimePost { get; set; }
        public int IdUser { get; set; }
        public string Content { get; set; }
        public int IdStreet { get; set; }
        public int IdWard { get; set; }
        public int IdDistrict { get; set; }
        public int IdCity { get; set; }
        public string StatePost { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Address Address1 { get; set; }
        public virtual Address Address2 { get; set; }
        public virtual Address Address3 { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
        public virtual User User { get; set; }
    }
}