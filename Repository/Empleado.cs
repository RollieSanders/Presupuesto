using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class Empleado
    {
        private readonly string strConnection = "";
        public Empleado()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Formulacion();
        }
        public DataSet Ayuda_Empleado_Jefatura()
        {

            DataSet ds = new DataSet();

            ds = SqlHelper.ExecuteDataset(strConnection,
                                      "General.spp_help_msto_Empleado_Jefatura"
                                     );

            return ds;
        }


        public Model.Empleado Recupera_Empleado_Codigo(string strCodEmpleado)
        {
            DataTable dt = new DataTable();
            Model.Empleado obj = new Model.Empleado();

            dt = SqlHelper.ExecuteDataTable(strConnection, "General.spp_sel_msto_Empleado_Codigo", strCodEmpleado);

            if (dt.Rows.Count == 0)
            {

                obj.CCodPersonal = "";
                obj.VApePersonal = "";
                obj.CCodEscalaViaje = "";
                obj.VNomEscalaViaje = "";
                obj.CCodCargo = "";
                obj.VDesCargo = "";
                obj.CDni = "";
                obj.CCodTipoEmpleado = "";
                obj.VDesTipoEmpleado = "";
                obj.CCodCentroCosto = "";
                obj.VNomCentroCosto = "";
                obj.CCodCentroGestor = "";
                obj.VNomCentroGestor = "";
                obj.CCodCentroBeneficio = "";
                obj.VNomCentroBeneficio = "";
                obj.CCodCentro = "";
                obj.VNomCentro = "";
                obj.CCodZona = "";
                obj.VNomzona = "";
                obj.Idigito = 2;

            }
            else
            {

                obj.CCodPersonal = Convert.ToString(dt.Rows[0][0]);
                obj.VApePersonal = Convert.ToString(dt.Rows[0][1]);
                obj.CCodEscalaViaje = Convert.ToString(dt.Rows[0][2]);
                obj.VNomEscalaViaje = Convert.ToString(dt.Rows[0][3]);
                obj.CCodCargo = Convert.ToString(dt.Rows[0][4]);
                obj.VDesCargo = Convert.ToString(dt.Rows[0][5]);
                obj.CDni = Convert.ToString(dt.Rows[0][6]);
                obj.CCodTipoEmpleado = Convert.ToString(dt.Rows[0][7]);
                obj.VDesTipoEmpleado = Convert.ToString(dt.Rows[0][8]);
                obj.CCodCentroCosto = Convert.ToString(dt.Rows[0][9]);
                obj.VNomCentroCosto = Convert.ToString(dt.Rows[0][10]);
                obj.CCodCentroGestor = Convert.ToString(dt.Rows[0][11]);
                obj.VNomCentroGestor = Convert.ToString(dt.Rows[0][12]);
                obj.CCodCentroBeneficio = Convert.ToString(dt.Rows[0][13]);
                obj.VNomCentroBeneficio = Convert.ToString(dt.Rows[0][14]);
                obj.CCodCentro = Convert.ToString(dt.Rows[0][15]);
                obj.VNomCentro = Convert.ToString(dt.Rows[0][16]);
                obj.CCodZona = Convert.ToString(dt.Rows[0][17]);
                obj.VNomzona = Convert.ToString(dt.Rows[0][18]);
                obj.Idigito = Convert.ToInt32(dt.Rows[0][19]);

            }

            return obj;

        }

        public DataSet Ayuda_Empleado()
        {

            DataSet ds = new DataSet();

            ds = SqlHelper.ExecuteDataset(strConnection,
                                      "General.spp_help_msto_Empleado"
                                     );

            return ds;
        }

        public Model.Empleado GetEmpleado(string strCodEmpleado)
        {
            DataTable dt = new DataTable();
            Model.Empleado objMES = new Model.Empleado();

            dt = SqlHelper.ExecuteDataTable(strConnection, "General.spp_sel_Msto_Empleado_Codigo_Smart", strCodEmpleado);

            foreach (DataRow row in dt.Rows)
            {
                objMES = GetEmpDataTableRow(row);
            }

            return objMES;
        }

        private Model.Empleado GetEmpDataTableRow(DataRow dr)
        {
            Model.Empleado obj = new Model.Empleado();

            obj.CCodPersonal = Convert.ToString(dr[0]);
            obj.VApePersonal = Convert.ToString(dr[1]);
            obj.CCodEscalaViaje = Convert.ToString(dr[2]);
            obj.VNomEscalaViaje = Convert.ToString(dr[3]);
            obj.CCodCargo = Convert.ToString(dr[4]);
            obj.VDesCargo = Convert.ToString(dr[5]);
            obj.CDni = Convert.ToString(dr[6]);
            obj.CCodTipoEmpleado = Convert.ToString(dr[7]);
            obj.VDesTipoEmpleado = Convert.ToString(dr[8]);
            obj.CCodCentroCosto = Convert.ToString(dr[9]);
            obj.VNomCentroCosto = Convert.ToString(dr[10]);
            obj.CCodCentroGestor = Convert.ToString(dr[11]);
            obj.VNomCentroGestor = Convert.ToString(dr[12]);
            obj.CCodCentroBeneficio = Convert.ToString(dr[13]);
            obj.VNomCentroBeneficio = Convert.ToString(dr[14]);
            obj.CCodCentro = Convert.ToString(dr[15]);
            obj.VNomCentro = Convert.ToString(dr[16]);
            obj.CCodZona = Convert.ToString(dr[17]);
            obj.VNomzona = Convert.ToString(dr[18]);
            obj.Idigito = Convert.ToInt32(dr[19]);
            obj.Cpaso = Convert.ToString(dr[20]);

            return (obj);
        }

    }
}
