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
    
    public partial class PersonalFile
    {
        public int ID_Username { get; set; }
        public int id_Discipline { get; set; }
        public int id_Chapter { get; set; }
        public int points { get; set; }
        public int PersonalLvl { get; set; }
    
        public virtual t_Chapters t_Chapters { get; set; }
        public virtual t_Disciplines t_Disciplines { get; set; }
        public virtual t_Users t_Users { get; set; }
    }
}
