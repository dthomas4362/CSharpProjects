//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Legacy_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public address()
        {
            this.user_addresses = new HashSet<user_addresses>();
        }
    
        public int id { get; set; }
        public string address1 { get; set; }
        public string postal_code { get; set; }
        public Nullable<int> state_id { get; set; }
    
        public virtual state state { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_addresses> user_addresses { get; set; }
    }
}
