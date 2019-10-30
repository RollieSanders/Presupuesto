using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class Material
    {
        private readonly string strConnection = "";
        public Material()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Formulacion();
        }

        public Model.Material Recupera_Material(string strCodMaterial)
        {
            DataTable dt = new DataTable();
            Model.Material obj = new Model.Material();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Logistica.spp_sel_msto_Material", strCodMaterial);

            if (dt.Rows.Count == 0)
            {
                obj.CcodMaterial = "";
                obj.VnomMaterial = "";
                obj.CcodUnidadMedida = "";
                obj.Fstock = 0;
            }
            else
            {
                obj.CcodMaterial = Convert.ToString(dt.Rows[0][0]);
                obj.VnomMaterial = Convert.ToString(dt.Rows[0][1]);
                obj.CcodUnidadMedida = Convert.ToString(dt.Rows[0][2]);
                obj.Fstock = Convert.ToDouble(dt.Rows[0][3]);
            }

            return obj;

        }

        public Model.Servicio Recupera_Servicio(string strCodServicio)
        {
            DataTable dt = new DataTable();
            Model.Servicio obj = new Model.Servicio();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Logistica.spp_sel_msto_Servicio", strCodServicio);

            if (dt.Rows.Count == 0)
            {
                obj.CcodServicio = "";
                obj.VnomServicio = "";
            }
            else
            {
                obj.CcodServicio = Convert.ToString(dt.Rows[0][0]);
                obj.VnomServicio = Convert.ToString(dt.Rows[0][1]);
            }

            return obj;

        }

        public DataSet Ayuda_Material( string strTexto )
        {

            DataSet ds = new DataSet();

            ds = SqlHelper.ExecuteDataset(strConnection,
                                      "Logistica.spp_help_msto_Material", strTexto
                                     );

            return ds;
        }

        public DataSet Ayuda_Servicio(  string strCodPosPre )
        {

            DataSet ds = new DataSet();

            ds = SqlHelper.ExecuteDataset(strConnection,
                                      "Logistica.spp_help_msto_Servicio", strCodPosPre
                                     );

            return ds;
        }
    }
}
