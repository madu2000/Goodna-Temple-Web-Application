//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ALI_EMPLOYEE
    {
        public ALI_EMPLOYEE()
        {
            this.ALI_INNER_EMP_DSG = new HashSet<ALI_INNER_EMP_DSG>();
        }
    
        public string EMP_NUMBER { get; set; }
        public string EMP_FIRSTNAME { get; set; }
        public string EMP_SURNAME { get; set; }
        public string EMP_DISPLAYNAME { get; set; }
        public string EMP_NIC { get; set; }
        public string EMP_EMAIL { get; set; }
    
        public virtual ICollection<ALI_INNER_EMP_DSG> ALI_INNER_EMP_DSG { get; set; }
    }
}
