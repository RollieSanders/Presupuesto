using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFgestion.Modelo
{
    [DataContract]
    public class RequerimientoWCF
    {
        [DataMember]
        public int IidRequerimiento_Cabecera { get; set; } = 0;
        [DataMember]
        public string CnumRequerimiento { get; set; } = "";
        [DataMember]
        public DateTime DfecRequerimiento { get; set; } = DateTime.Today;
        [DataMember]
        public string Tnota { get; set; } = "";
        [DataMember]
        public int IidRequerimiento_Detalle { get; set; } = 0;
        [DataMember]
        public string cCodFuenteFinanciamiento { get; set; } = "";
        [DataMember]
        public string vNomFuenteFinanciamiento { get; set; } = "";
        [DataMember]
        public string CcodCeCo { get; set; } = "";
        [DataMember]
        public string vNomCeCo { get; set; } = "";
        [DataMember]
        public string CcodProyecto { get; set; } = "";
        [DataMember]
        public string vNomCortoProyecto { get; set; } = "";
        [DataMember]
        public string CcodComponente { get; set; } = "";
        [DataMember]
        public string CcodPosPre { get; set; } = "";
        [DataMember]
        public string vNomPosPre { get; set; } = "";
        [DataMember]
        public string CcodClasificador { get; set; } = "";
        [DataMember]
        public string vNomClasificador { get; set; } = "";
        [DataMember]
        public string CcodTipoGasto { get; set; } = "";
        [DataMember]
        public string vNomClaseGasto { get; set; } = "";
        [DataMember]
        public string CcodTipoAdquisicion { get; set; } = "";
        [DataMember]
        public string vNomTipoAdquisicion { get; set; } = "";
        [DataMember]
        public double FimporteTotal { get; set; } = 0;
        [DataMember]
        public int IidRequerimiento_Detalle_Bien { get; set; } = 0;
        [DataMember]
        public string CcodMaterial { get; set; } = "";
        [DataMember]
        public string vNomMaterial { get; set; } = "";
        [DataMember]
        public string TespecificacionTecnica_B { get; set; } = "";
        [DataMember]
        public string CcodUnidadMedida { get; set; } = "";
        [DataMember]
        public string vNomUnidadMedida { get; set; } = "";
        [DataMember]
        public double Fcantidad { get; set; } = 0;
        [DataMember]
        public double FprecioUnitario { get; set; } = 0;
        [DataMember]
        public double Fstock { get; set; } = 0;
        [DataMember]
        public int IidRequerimiento_Detalle_Servicio { get; set; } = 0;
        [DataMember]
        public string CcodServicio { get; set; } = "";
        [DataMember]
        public string vNomServicio { get; set; } = "";
        [DataMember]
        public string TespecificacionTecnica_S { get; set; } = "";
    }
}