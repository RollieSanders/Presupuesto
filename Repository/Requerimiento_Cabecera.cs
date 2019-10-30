using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class Requerimiento_Cabecera
    {
        private string strConnection = "";
        public Requerimiento_Cabecera()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Formulacion();
        }

        public Model.Requerimiento_Cabecera Recupera_Requerimiento_Cabecera(int intIdRequrimiento_Cabecera)
        {
            DataTable dt = new DataTable();
            Model.Requerimiento_Cabecera obj = new Model.Requerimiento_Cabecera();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_sel_mvto_Requerimiento_Cabecera", intIdRequrimiento_Cabecera);

            if (dt.Rows.Count == 0)
            {
                obj.IidRequerimiento_Cabecera = 0;
                obj.CañoProceso = "";
                obj.CcodCeCo_Gestor = "";
                obj.CnumRequerimiento = "";
                obj.DfecRequerimiento = DateTime.Today;
                obj.Tnota = "";
                obj.CcodTipoAdquisicion = "";
                obj.CcodPrioridad = "";
                obj.CcodTipoMoneda = "";
                obj.FtipoCambio = 0.0;
                obj.Tjustificacion = "";
            }
            else
            {
                obj.IidRequerimiento_Cabecera = Convert.ToInt32(dt.Rows[0][0]);
                obj.CañoProceso = Convert.ToString(dt.Rows[0][1]); 
                obj.CcodCeCo_Gestor = Convert.ToString(dt.Rows[0][2]);
                obj.CnumRequerimiento = Convert.ToString(dt.Rows[0][3]);
                obj.DfecRequerimiento = Convert.ToDateTime(dt.Rows[0][4]);
                obj.Tnota = Convert.ToString(dt.Rows[0][5]);
                obj.CcodTipoAdquisicion = Convert.ToString(dt.Rows[0][6]);
                obj.CcodPrioridad = Convert.ToString(dt.Rows[0][7]);
                obj.CcodTipoMoneda = Convert.ToString(dt.Rows[0][8]);
                obj.FtipoCambio = Convert.ToDouble(dt.Rows[0][9]);
                obj.Tjustificacion = Convert.ToString(dt.Rows[0][10]);
            }

            return obj;

        }

        public Model.Requerimiento_Cabecera Graba_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {

            Model.Requerimiento_Cabecera MRC = new Model.Requerimiento_Cabecera();
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_ins_mvto_Requerimiento_Cabecera", obj.CañoProceso,
                                                                                                            obj.CcodCeCo_Gestor,
                                                                                                            obj.CnumRequerimiento,
                                                                                                            obj.DfecRequerimiento,
                                                                                                            obj.Tnota,
                                                                                                            obj.CcodTipoAdquisicion,
                                                                                                            obj.CcodPrioridad,
                                                                                                            obj.CcodTipoMoneda,
                                                                                                            obj.FtipoCambio,
                                                                                                            obj.Tjustificacion
                                                          );
                MRC.IidRequerimiento_Cabecera = Convert.ToInt32(dt.Rows[0][0]);
                MRC.CnumRequerimiento = Convert.ToString(dt.Rows[0][1]);
            }
            catch
            {
                MRC.IidRequerimiento_Cabecera = 0;
                MRC.CnumRequerimiento = "";
            }
            return MRC;
        }

        public int Modifica_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {
            int intIdRequerimiento_Cabecera = 0;
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_upd_mvto_Requerimiento_Cabecera", obj.IidRequerimiento_Cabecera,
                                                                                                            obj.CañoProceso,
                                                                                                            obj.CcodCeCo_Gestor,
                                                                                                            obj.CnumRequerimiento,
                                                                                                            obj.DfecRequerimiento,
                                                                                                            obj.Tnota,
                                                                                                            obj.CcodTipoAdquisicion,
                                                                                                            obj.CcodPrioridad,
                                                                                                            obj.CcodTipoMoneda,
                                                                                                            obj.FtipoCambio,
                                                                                                            obj.Tjustificacion
                                                          );
                intIdRequerimiento_Cabecera = obj.IidRequerimiento_Cabecera;
            }
            catch
            {
                intIdRequerimiento_Cabecera = 0;
            }
            return intIdRequerimiento_Cabecera;
        }

        public int Elimina_Requerimiento_Cabecera(int intIdRequerimiento_Cabecera)
        {
            int intResultado = 0;

            try
            {
                intResultado = Convert.ToInt32(SqlHelper.ExecuteScalar(strConnection, "Gestion.spp_del_mvto_Requerimiento_Cabecera", intIdRequerimiento_Cabecera));

            }
            catch
            {
                intResultado = 0;
            }
            return intResultado;
        }

    }
}
