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
    
    public partial class users_hobbies
    {
        public int id { get; set; }
        public Nullable<int> users_id { get; set; }
        public Nullable<int> hobbies_id { get; set; }
    
        public virtual hobby hobby { get; set; }
        public virtual user user { get; set; }
    }
}
