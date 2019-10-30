using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINgestion
{
    public static class MyStuff
    {
        public static string CodigoEmpleado { get; set; }
        public static string CodigoJefatura { get; set; }
        public static string AñoProceso { get; set; }
        public static string PeriodoProceso { get; set; }
        public static string RutaServidor { get; set; }
        public static string CodigoCentroCosto { get; set; }
        public static string NombreCentroCosto { get; set; }
        public static string CodigoCentroGestor { get; set; }
        public static string NombreCentroGestor { get; set; }
        public static int DigitoCentroGestor { get; set; }
        public static string Empresa { get; set; }
        public static string Version { get; set; }

        public static bool UsaWCF { get; set; }

        static MyStuff()
        {


            CodigoEmpleado = "60000194";
            CodigoJefatura = "60000194";
            AñoProceso = "2020";
            PeriodoProceso = "2012001";
            RutaServidor = ""; //"D:\Logistica";
            UsaWCF = true;
            CodigoCentroCosto = "101050";
            NombreCentroCosto = "Gerencia de Administracion";
            CodigoCentroGestor = "101020";
            NombreCentroGestor = "GERENCIA DE ADMINISTRACION";
            Empresa = "Activos Mineros SAC";
            Version = "01";
            DigitoCentroGestor = 8;
        }
    }
}
