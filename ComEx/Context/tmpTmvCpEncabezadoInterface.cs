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
    
    public partial class tmpTmvCpEncabezadoInterface
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tmpTmvCpEncabezadoInterface()
        {
            this.tmpTmvCpDetalleInterface = new HashSet<tmpTmvCpDetalleInterface>();
        }
    
        public string C1_ano { get; set; }
        public string C2_concepto { get; set; }
        public string C4_numeroFormulario { get; set; }
        public string C6_SciDigitoVerificacion { get; set; }
        public string C11_SciRazonSocial { get; set; }
        public string C18_SciNit { get; set; }
        public string C20_SciTipoDocumento { get; set; }
        public string C24_proveeTipoDocumento { get; set; }
        public string C25_proveeNit { get; set; }
        public string C26_proveeDigitoVerificacion { get; set; }
        public string C27_proveePrimerApellido { get; set; }
        public string C28_proveeSegundoApellido { get; set; }
        public string C29_proveePrimerNombre { get; set; }
        public string C30_proveeOtrosNombres { get; set; }
        public string C31_proveeRazonSocial { get; set; }
        public string C32_numFormularioAnterior { get; set; }
        public string C33_fecFormularioAnterior { get; set; }
        public string C34_CantidadDeFacturas { get; set; }
        public string C35_ValorTtalCnslddo { get; set; }
        public string C36_ValorTtalExcncionIva { get; set; }
        public string C37_EfectosCP { get; set; }
        public string C38_FecLmteExprtcion { get; set; }
        public string C39_NoDeitems { get; set; }
        public string C997_fechaAceptacion { get; set; }
        public string C1001_apellidosNombresQuienSuscribeDocumento { get; set; }
        public string C1002_tipoDocumentoQuienSuscribeDocumento { get; set; }
        public string C1003_numeroIdentificacionQuienSuscribeDocumento { get; set; }
        public string C1004_digitoVerificacionQuienSuscribeDocumento { get; set; }
        public string C1005_codigoRepresentacionQuienSuscribeDocumento { get; set; }
        public string C1006_organizacionQuienSuscribeDocumento { get; set; }
        public string nombreArchivo { get; set; }
        public string intIdIntrfceErrores { get; set; }
        public string archivoAdjunto { get; set; }
        public Nullable<int> intIdPlanCI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tmpTmvCpDetalleInterface> tmpTmvCpDetalleInterface { get; set; }
    }
}
