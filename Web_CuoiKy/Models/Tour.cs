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
    
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            this.BookingDetails = new HashSet<BookingDetail>();
            this.Favourites = new HashSet<Favourite>();
            this.Posts = new HashSet<Post>();
            this.Reviews = new HashSet<Review>();
            this.Schedules = new HashSet<Schedule>();
            this.Tour_Destination = new HashSet<Tour_Destination>();
            this.TourImages = new HashSet<TourImage>();
            this.Discounts = new HashSet<Discount>();
        }
    
        public int TourId { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> TimeStart { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
        public string DayNumber { get; set; }
        public Nullable<int> MaxCountTicket { get; set; }
        public Nullable<decimal> PriceChild { get; set; }
        public Nullable<decimal> PriceAdult { get; set; }
        public string Descriptions { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string DiChuyen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favourite> Favourites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour_Destination> Tour_Destination { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourImage> TourImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Discount> Discounts { get; set; }
    }
}
