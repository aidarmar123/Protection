//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProtectionApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Sename { get; set; }
        public string Surname { get; set; }
        public string VisitPurpose { get; set; }
        public int StateId { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> TimeEntry { get; set; }
        public Nullable<System.DateTime> TimeExit { get; set; }
    
        public virtual State State { get; set; }
    }
}
