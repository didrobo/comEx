//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComEx.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class tmComprasTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tmComprasTipo()
        {
            this.tmInsumos = new HashSet<tmInsumos>();
        }
    
        public int intIdTpoCmpra { get; set; }
        public string varCdTpoCmpra { get; set; }
        public string varDscrpcionCmpra { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmInsumos> tmInsumos { get; set; }
    }
}
