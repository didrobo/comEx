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
    
    public partial class tmDocumentosAdjuntos
    {
        public int intIdDcmntosAdjntosDtlle { get; set; }
        public Nullable<int> intIdTpoDcmntoArchvosAdjntos { get; set; }
        public string varRta { get; set; }
        public string varObsrvciones { get; set; }
        public string varFrmlrio { get; set; }
        public Nullable<long> intIdDcmnto { get; set; }
        public string varDcmnto { get; set; }
        public Nullable<System.DateTime> fecEnvio { get; set; }
        public Nullable<bool> bitCnfrmcionEmail { get; set; }
        public Nullable<bool> bitMrcar { get; set; }
        public Nullable<int> intidUsuario { get; set; }
    
        public virtual tipoDocumentosArchivosAdjuntos tipoDocumentosArchivosAdjuntos { get; set; }
    }
}
