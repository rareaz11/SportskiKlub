//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sportski_klub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clanarina
    {
        public int ID { get; set; }
        public int SportasID { get; set; }
        public int KlubID { get; set; }
        public System.DateTime Mjesec { get; set; }
        public double Iznos { get; set; }
    
        public virtual Klub Klub { get; set; }
        public virtual Sportas Sportas { get; set; }
    }
}
