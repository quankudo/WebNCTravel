//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_CuoiKy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public string ImageTitle { get; set; }
        public Nullable<int> TourId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<bool> IsApproved { get; set; }
    
        public virtual Tour Tour { get; set; }
        public virtual User User { get; set; }
    }
}