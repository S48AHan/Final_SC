//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpeedyCouriers.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransactionInfo()
        {
            this.DeliveryInfoes = new HashSet<DeliveryInfo>();
        }
    
        public int transactionID { get; set; }
        public Nullable<int> tranOrderID { get; set; }
        public Nullable<int> tranUserID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryInfo> DeliveryInfoes { get; set; }
        public virtual DeliveryMan DeliveryMan { get; set; }
        public virtual OrderInfo OrderInfo { get; set; }
    }
}
