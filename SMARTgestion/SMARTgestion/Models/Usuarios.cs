using System;
using System.Collections.Generic;
using System.Text;

namespace SMARTgestion.Models
{
    public class Usuarios
    {
        public long iIdUsuario { get; set; } = 0;
        public string vLogUsuario { get; set; } = "";
        public string tClaUsuario { get; set; } = "";
        public string tPasUsuario { get; set; } = "";
        public string tVecUsuario { get; set; } = "";
        public string cCodTipoEmpleado { get; set; } = "";
        public string cCodEmpleado { get; set; } = "";
        public string vDesEmpleado { get; set; } = "";
        public bool bEstado { get; set; } = false;
    }
}
