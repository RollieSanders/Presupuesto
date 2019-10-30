using System;
using System.Collections.Generic;
using System.Text;

namespace SMARTgestion.Models
{
    public class Requerimientos
    {
        public int IidRequerimiento_Cabecera { get; set; } = 0;
		public string CnumRequerimiento { get; set; } = "";
		public DateTime DfecRequerimiento { get; set; } = DateTime.Today;
		public string Tnota { get; set; } = "";
		public int IidRequerimiento_Detalle { get; set; } = 0;
		public string cCodFuenteFinanciamiento { get; set; } = "";
        public string vNomFuenteFinanciamiento { get; set; } = "";
        public string CcodCeCo { get; set; } = "";
        public string vNomCeCo { get; set; } = "";
        public string CcodProyecto { get; set; } = "";
        public string vNomCortoProyecto { get; set; } = "";
        public string CcodComponente { get; set; } = "";
        public string CcodPosPre { get; set; } = "";
        public string vNomPosPre { get; set; } = "";
        public string CcodClasificador { get; set; } = "";
        public string vNomClasificador { get; set; } = "";
        public string CcodTipoGasto { get; set; } = "";
        public string vNomClaseGasto { get; set; } = "";
        public string CcodTipoAdquisicion { get; set; } = "";
        public string vNomTipoAdquisicion { get; set; } = "";
		public double FimporteTotal { get; set; } = 0;
		public int IidRequerimiento_Detalle_Bien { get; set; } = 0;
		public string CcodMaterial { get; set; } = "";
        public string vNomMaterial { get; set; } = "";
        public string TespecificacionTecnica_B { get; set; } = "";
        public string CcodUnidadMedida { get; set; } = "";
        public string vNomUnidadMedida { get; set; } = "";
        public double Fcantidad { get; set; } = 0;
		public double FprecioUnitario { get; set; } = 0;
		public double Fstock { get; set; } = 0;
		public int IidRequerimiento_Detalle_Servicio { get; set; } = 0;
		public string CcodServicio { get; set; } = "";
        public string vNomServicio { get; set; } = "";
        public string TespecificacionTecnica_S { get; set; } = "";
        public string Cpaso { get; set; } = "";
    }
}
