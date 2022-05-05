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
    using System.ComponentModel.DataAnnotations;

    public partial class tmvDEXEncabezado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tmvDEXEncabezado()
        {
            this.tmvDexCorreciones = new HashSet<tmvDexCorreciones>();
            this.tmvDEXDetalle = new HashSet<tmvDEXDetalle>();
            this.tmvDexPdfCPs = new HashSet<tmvDexPdfCPs>();
            this.tmvFacturasExportacionNotasCredito = new HashSet<tmvFacturasExportacionNotasCredito>();
        }

        public int intIdDEX { get; set; }
        [Display(Name = "Auxilar")]
        public string varCdAuxliar { get; set; }
        [Display(Name = "F. Auxilar")]
        public Nullable<System.DateTime> fecAuxliar { get; set; }
        [Display(Name = "DEX")]
        public string varNmroDEX { get; set; }
        [Display(Name = "F. DEX")]
        public Nullable<System.DateTime> fecAprbcionDEX { get; set; }
        [Display(Name = "F. Embarque")]
        public Nullable<System.DateTime> fecEmbrque { get; set; }
        public Nullable<System.DateTime> fecDeudaExtrna { get; set; }
        [Display(Name = "Exportador")]
        public int intIdImprtdorExprtdor { get; set; }
        [Display(Name = "Comprador")]
        public int intIdCmprdor { get; set; }
        [Display(Name = "Aduana")]
        public Nullable<int> intIdAduana { get; set; }
        [Display(Name = "Comentario")]
        [DataType(DataType.MultilineText)]
        public string varCmntrio { get; set; }
        [Display(Name = "Fletes")]
        public Nullable<decimal> numFltes { get; set; }
        [Display(Name = "Seguro")]
        public Nullable<decimal> numSgro { get; set; }
        [Display(Name = "Otros Gastos")]
        public Nullable<decimal> numOtrosGstos { get; set; }
        public string varRtaArchvoAdjnto { get; set; }
        [Display(Name = "Declarante")]
        public Nullable<int> intIdDclrnte { get; set; }
        [Display(Name = "Destino Final")]
        public Nullable<int> intIdLgarEmbrque { get; set; }
        [Display(Name = "Vr. FOB")]
        public Nullable<decimal> numVlorFOB { get; set; }
        [Display(Name = "Vr. Exportaciones")]
        public Nullable<decimal> numExprtcionesUSD { get; set; }
        [Display(Name = "Vr. Reintegrar")]
        public Nullable<decimal> numVlorReintgrarUSD { get; set; }
        [Display(Name = "Vr. Agregado Nal.")]
        public Nullable<decimal> numVlorAgrgdoNcional { get; set; }
        [Display(Name = "Ttal. Series")]
        public Nullable<decimal> numTtalSries { get; set; }
        [Display(Name = "Bultos")]
        public Nullable<decimal> numBltos { get; set; }
        [Display(Name = "Peso Bruto")]
        public Nullable<decimal> numTtalPsoBrto { get; set; }
        [Display(Name = "Peso Neto")]
        public Nullable<decimal> numTtalPsoNto { get; set; }
        [Display(Name = "Aceptaci�n")]
        public string numNumroAcptcion { get; set; }
        [Display(Name = "F. Aceptaci�n")]
        public Nullable<System.DateTime> fecAcptcion { get; set; }
        [Display(Name = "SAE")]
        public string varSlctudAtrzcionEmbrque { get; set; }
        [Display(Name = "F. SAE")]
        public Nullable<System.DateTime> fecAtrzcionEmbrque { get; set; }
        [Display(Name = "Manifiesto")]
        public string varMnfiestoCrga { get; set; }
        [Display(Name = "F. Manifiesto")]
        public Nullable<System.DateTime> fecMnfiestoCrga { get; set; }
        [Display(Name = "Transporte")]
        public Nullable<int> intIdTrnsprte { get; set; }
        public Nullable<int> intIdTpoPriodo { get; set; }
        public Nullable<decimal> numCntdadEmblje { get; set; }
        public Nullable<bool> bitEnviado { get; set; }
        public Nullable<int> intIdMesCntble { get; set; }
        public string varAnoCntble { get; set; }
        [Display(Name = "Plan CI")]
        public Nullable<int> intIdPlanCI { get; set; }
        [Display(Name = "Formulario Anterior")]
        public string varNmroFrmlrioAntrior { get; set; }
        public Nullable<int> intIdDcmntoTrnsprte { get; set; }
        [Display(Name = "Doc. Transporte")]
        public string varNmroDcmntoTrnsprte { get; set; }
        [Display(Name = "F. Doc. Trnsprte")]
        public Nullable<System.DateTime> fecDcmntoTrnsprte { get; set; }
        [Display(Name = "Transportador")]
        public Nullable<int> intIdTrnsprtdor { get; set; }
        public Nullable<int> intIdFrmaPgo { get; set; }
        public Nullable<int> intIdTpoDex { get; set; }
        public Nullable<int> intIdPlan { get; set; }
        public Nullable<int> intIdCmpnia { get; set; }
        public Nullable<int> intIdIntrfceErrorAudtoriaDtos { get; set; }
        public Nullable<int> intIdUndadEstrtgcaNgcios { get; set; }
        public Nullable<bool> bitMrcar { get; set; }
        public string varNumDO { get; set; }

        public virtual tmPlanesCI tmPlanesCI { get; set; }
        public virtual tmCompradores tmCompradores { get; set; }
        public virtual tmImportadorExportador tmImportadorExportador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmvDexCorreciones> tmvDexCorreciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmvDEXDetalle> tmvDEXDetalle { get; set; }
        public virtual tmAduanas tmAduanas { get; set; }
        public virtual tmLugaresEmbarque tmLugaresEmbarque { get; set; }
        public virtual tmTerceros tmTerceros { get; set; }
        public virtual tmTerceros tmTerceros1 { get; set; }
        public virtual tmTransportes tmTransportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmvDexPdfCPs> tmvDexPdfCPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmvFacturasExportacionNotasCredito> tmvFacturasExportacionNotasCredito { get; set; }
    }
}