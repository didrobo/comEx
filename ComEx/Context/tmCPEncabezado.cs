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
    
    public partial class tmCPEncabezado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tmCPEncabezado()
        {
            this.tmCPDetalle = new HashSet<tmCPDetalle>();
            this.tmCPEncabezado1 = new HashSet<tmCPEncabezado>();
            this.tmCompras = new HashSet<tmCompras>();
            this.tmvDexPdfCPs = new HashSet<tmvDexPdfCPs>();
        }
    
        public int intIdCP { get; set; }
        public string varCdCP { get; set; }
        public Nullable<System.DateTime> fecCP { get; set; }
        public Nullable<int> intIdPlanCI { get; set; }
        public Nullable<bool> bitAnldo { get; set; }
        public Nullable<System.DateTime> fecBmstre { get; set; }
        public Nullable<int> intIdPrvdor { get; set; }
        public Nullable<int> intIdCPMdfccion { get; set; }
        public Nullable<System.DateTime> fecMdfccion { get; set; }
        public string varMtvoMdfccion { get; set; }
        public Nullable<System.DateTime> fecRdccion { get; set; }
        public Nullable<bool> bitMrcar { get; set; }
        public string varNmroCP { get; set; }
        public Nullable<System.DateTime> fecAprbcionCP { get; set; }
        public string varRtaArchvoAdjnto { get; set; }
        public Nullable<int> intIdCmpraCreacionTmp { get; set; }
        public string varNmroCPManual { get; set; }
        public Nullable<System.DateTime> fecCPManual { get; set; }
        public Nullable<int> intIdPriodo { get; set; }
        public Nullable<int> intCnsctvo { get; set; }
        public Nullable<int> intIdCmpra { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmCPDetalle> tmCPDetalle { get; set; }
        public virtual tmPlanesCI tmPlanesCI { get; set; }
        public virtual tmProveedores tmProveedores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmCPEncabezado> tmCPEncabezado1 { get; set; }
        public virtual tmCPEncabezado tmCPEncabezado2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmCompras> tmCompras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmvDexPdfCPs> tmvDexPdfCPs { get; set; }
        public virtual tmCompras tmCompras1 { get; set; }
    }
}
