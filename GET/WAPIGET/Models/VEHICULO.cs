//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WAPIGET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VEHICULO
    {
        public int ID { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public Nullable<int> NYEAR { get; set; }
        public string CONDICION { get; set; }
        public Nullable<int> ESTATUS { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public string FOTO { get; set; }
    
        public virtual vhESTATU vhESTATU { get; set; }
    }
}
