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
    
    public partial class City
    {
        public City()
        {
            this.Districts = new HashSet<District>();
            this.Plans = new HashSet<Plan>();
            this.Posts = new HashSet<Post>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string NameCity { get; set; }
    
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
