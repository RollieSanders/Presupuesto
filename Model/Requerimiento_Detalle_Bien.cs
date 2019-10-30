using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Requerimiento_Detalle_Bien
    {
        public int IidRequerimiento_Detalle { get; set; } = 0;
        public int IidRequerimiento_Detalle_Bien { get; set; } = 0;
        public string TespecificacionTecnica { get; set; } = "";
        public string CcodMaterial { get; set; } = "";
        public double Fstock { get; set; } = 0.0;
        public double Fcantidad { get; set; } = 0.0;
        public double FprecioUnitario { get; set; } = 0.0;
        public double FprecioUnitario_Extranjero { get; set; } = 0.0;
        public string CcodUnidadMedida { get; set; } = "";
    }
}
