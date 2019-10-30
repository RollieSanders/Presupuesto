using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class Requerimiento_Detalle_Servicio
    {
        private string strConnection = "";
        public Requerimiento_Detalle_Servicio()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Formulacion();
        }

        public Model.Requerimiento_Detalle_Servicio Recupera_Requerimiento_Detalle_Servicio(int intIdRequrimiento_Detalle_Servicio)
        {
            DataTable dt = new DataTable();
            Model.Requerimiento_Detalle_Servicio obj = new Model.Requerimiento_Detalle_Servicio();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_sel_mvto_Requerimiento_Detalle_Servicio", intIdRequrimiento_Detalle_Servicio);

            if (dt.Rows.Count == 0)
            {
                obj.IidRequerimiento_Detalle = 0;
                obj.IidRequerimiento_Detalle_Servicio = 0;
                obj.CcodServicio = "";
                obj.TespecificacionTecnica = "";
                obj.Fprecio = 0;
                obj.Fprecio_Extranjero = 0;
            }
            else
            {
                obj.IidRequerimiento_Detalle = Convert.ToInt32(dt.Rows[0][0]);
                obj.IidRequerimiento_Detalle_Servicio = Convert.ToInt32(dt.Rows[0][1]);
                obj.CcodServicio = Convert.ToString(dt.Rows[0][2]);
                obj.TespecificacionTecnica = Convert.ToString(dt.Rows[0][3]);
                obj.Fprecio = Convert.ToDouble(dt.Rows[0][4]);
                obj.Fprecio_Extranjero = Convert.ToDouble(dt.Rows[0][5]);
            }

            return obj;

        }

        public int Graba_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            int intIdRequerimiento_Detalle_Servicio = 0;
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_ins_mvto_Requerimiento_Detalle_Servicio", obj.IidRequerimiento_Detalle,
                                                                                                                    obj.CcodServicio,
                                                                                                                    obj.TespecificacionTecnica,
                                                                                                                    obj.Fprecio,
                                                                                                                    obj.Fprecio_Extranjero
                                                          );
                intIdRequerimiento_Detalle_Servicio = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch
            {
                intIdRequerimiento_Detalle_Servicio = 0;
            }
            return intIdRequerimiento_Detalle_Servicio;
        }

        public int Modifica_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            int intIdRequerimiento_Detalle_Servicio = 0;
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_upd_mvto_Requerimiento_Detalle_Servicio", obj.IidRequerimiento_Detalle_Servicio,
                                                                                                                    obj.CcodServicio,
                                                                                                                    obj.TespecificacionTecnica,
                                                                                                                    obj.Fprecio,
                                                                                                                    obj.Fprecio_Extranjero
                                                          );
                intIdRequerimiento_Detalle_Servicio = obj.IidRequerimiento_Detalle_Servicio;
            }
            catch
            {
                intIdRequerimiento_Detalle_Servicio = 0;
            }
            return intIdRequerimiento_Detalle_Servicio;
        }

        public int Elimina_Requerimiento_Detalle_Servicio(int intIdRequerimiento_Detalle_Servicio)
        {
            int intResultado = 0;

            try
            {
                intResultado = Convert.ToInt32(SqlHelper.ExecuteScalar(strConnection, "Gestion.spp_del_mvto_Requerimiento_Detalle_Servicio", intIdRequerimiento_Detalle_Servicio));

            }
            catch
            {
                intResultado = 0;
            }
            return intResultado;
        }
    }
}
