//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectHQTCSDL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int idComment { get; set; }
        public int idUser { get; set; }
        public string commentContent { get; set; }
        public Nullable<int> idMusic { get; set; }
    
        public virtual Music Music { get; set; }
        public virtual UserMain UserMain { get; set; }
    }
}
