using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formulacion_Saldo
    {
        public string CañoProceso { get; set; } = "";
        public string CcodFuenteFinanciamiento { get; set; } = "";
        public string CcodCeCo_Gestor { get; set; } = "";
        public string CcodProyecto { get; set; } = "";
        public string CcodPosPre { get; set; } = "";
        public string CcodClasificador { get; set; } = "";
        public string CcodTipoGasto { get; set; } = "";
        public double fFormulado { get; set; } = 0.0;
        public double FimporteComprometido { get; set; } = 0.0;
        public double FimporteEjecutado { get; set; } = 0.0;
    }
}
