using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Paso_Requerimiento
    {
        public string CcodCeCo_Gestor { get; set; } = "";
        public string CnumRequerimiento { get; set; } = "";
        public DateTime DfecPaso { get; set; } = DateTime.Today;
        public string CPaso { get; set; } = "";
        public string CestadoPaso { get; set; } = "";
    }
}
