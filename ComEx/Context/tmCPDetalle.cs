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
    
    public partial class tmCPDetalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tmCPDetalle()
        {
            this.tmComprasDetalle = new HashSet<tmComprasDetalle>();
        }
    
        public int intIdCPDtlle { get; set; }
        public int intIdCp { get; set; }
        public string varCI { get; set; }
        public Nullable<decimal> numCntdadCp { get; set; }
        public Nullable<decimal> numCntdadCnsmda { get; set; }
        public Nullable<bool> bitMrcar { get; set; }
        public Nullable<bool> bitEdcionMnual { get; set; }
        public Nullable<decimal> numVlorCpPorCI { get; set; }
        public Nullable<decimal> numCntdadCpAnlda { get; set; }
        public Nullable<decimal> numVlorCpPorCiAnlda { get; set; }
    
        public virtual tmCPEncabezado tmCPEncabezado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmComprasDetalle> tmComprasDetalle { get; set; }
    }
}
