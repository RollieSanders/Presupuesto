using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class Paso_Requerimiento
    {
        private string strConnection;
        public Paso_Requerimiento()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Formulacion();
        }

        public Model.Paso_Requerimiento GetPaso_Requerimiento(string strNumRequerimiento
                                                             )
        {
            DataTable dt = new DataTable();


            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_ins_mvto_Requerimiento_Firma_Smart", strNumRequerimiento);

            Model.Paso_Requerimiento objMES = new Model.Paso_Requerimiento();

            foreach (DataRow row in dt.Rows)
            {
                objMES = GetEmpDataTableRow(row);
            }

            return objMES;
        }


        private Model.Paso_Requerimiento GetEmpDataTableRow(DataRow dr)
        {
            Model.Paso_Requerimiento objMES = new Model.Paso_Requerimiento();

            objMES.CcodCeCo_Gestor = Convert.ToString(dr["CcodCeCo_Gestor"]);
            objMES.CnumRequerimiento = Convert.ToString(dr["CnumRequerimiento"]);
            objMES.DfecPaso = Convert.ToDateTime(dr["DfecPaso"]);
            objMES.CPaso = Convert.ToString(dr["CPaso"]);
            objMES.CestadoPaso = Convert.ToString(dr["CestadoPaso"]);

            return (objMES);
        }

    }
}
