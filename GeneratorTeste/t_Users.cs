//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneratorTeste
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Users()
        {
            this.PersonalFile = new HashSet<PersonalFile>();
        }
    
        public int ID_User { get; set; }
        public string username { get; set; }
        public int ID_Password { get; set; }
    
        public virtual t_Passwords t_Passwords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalFile> PersonalFile { get; set; }
    }
}