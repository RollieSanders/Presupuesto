using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Material
    {
        public string CcodMaterial { get; set; } = "";
        public string VnomMaterial { get; set; } = "";
        public string CcodUnidadMedida { get; set; } = "";
        public double Fstock { get; set; } = 0;
    }
}
