//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace College.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doctor
    {
        public int Doc_id { get; set; }
        public string Doc_Name { get; set; }
        public int Doc_Num { get; set; }
    
        public virtual Doctor Doctor1 { get; set; }
        public virtual Doctor Doctor2 { get; set; }
        public virtual Student Student { get; set; }
    }
}
