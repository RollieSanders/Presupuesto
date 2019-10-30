using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WCFgestion.Data
{
    public class DataAccess
    {
        public string ReturnConnectionString_Acceso()
        {

            var strConn = ConfigurationManager.ConnectionStrings["CONEXACCESO"].ConnectionString;

            return strConn;
        }

        public string ReturnConnectionString_Formulacion()
        {
            var strConn = ConfigurationManager.ConnectionStrings["CONEXPRESUPUESTO"].ConnectionString;

            return strConn;
        }

        public string ReturnConnectionString_Gestion()
        {
            var strConn = ConfigurationManager.ConnectionStrings["CONEXPRESUPUESTO"].ConnectionString;

            return strConn;
        }

    }
}