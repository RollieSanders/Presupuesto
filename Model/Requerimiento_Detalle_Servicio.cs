using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Requerimiento_Detalle_Servicio
    {
        public int IidRequerimiento_Detalle { get; set; } = 0;
        public int IidRequerimiento_Detalle_Servicio { get; set; } = 0;
        public string TespecificacionTecnica { get; set; } = "";
        public string CcodServicio { get; set; } = "";
        public double Fprecio { get; set; } = 0.0;
        public double Fprecio_Extranjero { get; set; } = 0.0;
    }
}