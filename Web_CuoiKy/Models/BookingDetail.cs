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
    
    public partial class BookingDetail
    {
        public int BookingDetailId { get; set; }
        public Nullable<int> BookingId { get; set; }
        public Nullable<int> CountChild { get; set; }
        public Nullable<int> CountAdult { get; set; }
        public Nullable<decimal> PriceChild { get; set; }
        public Nullable<decimal> PriceAdult { get; set; }
        public Nullable<int> TourId { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Tour Tour { get; set; }
    }
}