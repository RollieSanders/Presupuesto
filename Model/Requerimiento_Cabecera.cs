using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Requerimiento_Cabecera
    {
        public int IidRequerimiento_Cabecera { get; set; } = 0;
        public string CcodCeCo_Gestor { get; set; } = "";
        public string CañoProceso { get; set; } = "";
        public DateTime DfecRequerimiento { get; set; } = DateTime.Today;
        public string CnumRequerimiento { get; set; } = "";
        public string Tnota { get; set; } = "";
        public string Tjustificacion { get; set; } = "";
        public string CcodTipoAdquisicion { get; set; } = "";
        public string CcodPrioridad { get; set; } = "";
        public string CcodTipoMoneda { get; set; } = "";
        public double FtipoCambio { get; set; } = 0.0;
    }
}
