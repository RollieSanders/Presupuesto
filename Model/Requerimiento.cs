using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Requerimiento
    {
        public string CnumRequerimiento { get; set; } = "";
        public DateTime DfecRequerimiento { get; set; } = DateTime.Today;
        public string Tnota { get; set; } = "";
        public string cCodFuenteFinanciamiento { get; set; } = "";
        public string vNomFuenteFinanciamiento { get; set; } = "";
        public string CcodCeCo { get; set; } = "";
        public string vNomCeCo { get; set; } = "";
        public string CcodProyecto { get; set; } = "";
        public string vNomCortoProyecto { get; set; } = "";
        public string CcodPosPre { get; set; } = "";
        public string vNomPosPre { get; set; } = "";
        public string CcodClasificador { get; set; } = "";
        public string vNomClasificador { get; set; } = "";
        public string CcodTipoGasto { get; set; } = "";
        public string vNomClaseGasto { get; set; } = "";
        public string CcodTipoAdquisicion { get; set; } = "";
        public string vNomTipoAdquisicion { get; set; } = "";
        public double FimporteTotal { get; set; } = 0;
        public string cPaso { get; set; } = "";

    }
}
