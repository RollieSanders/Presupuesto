using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class Requerimiento_Detalle_Bien
    {
        private string strConnection = "";
        public Requerimiento_Detalle_Bien()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Formulacion();
        }

        public Model.Requerimiento_Detalle_Bien Recupera_Requerimiento_Detalle_Bien(int intIdRequrimiento_Detalle_Bien)
        {
            DataTable dt = new DataTable();
            Model.Requerimiento_Detalle_Bien obj = new Model.Requerimiento_Detalle_Bien();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_sel_mvto_Requerimiento_Detalle_Bien", intIdRequrimiento_Detalle_Bien);

            if (dt.Rows.Count == 0)
            {
                obj.IidRequerimiento_Detalle = 0;
                obj.IidRequerimiento_Detalle_Bien = 0;
                obj.CcodMaterial = "";
                obj.TespecificacionTecnica = "";
                obj.CcodUnidadMedida = "";
                obj.Fcantidad = 0;
                obj.FprecioUnitario = 0;
                obj.FprecioUnitario_Extranjero = 0;
                obj.Fstock = 0;
            }
            else
            {
                obj.IidRequerimiento_Detalle = Convert.ToInt32(dt.Rows[0][0]);
                obj.IidRequerimiento_Detalle_Bien = Convert.ToInt32(dt.Rows[0][1]);
                obj.CcodMaterial = Convert.ToString(dt.Rows[0][2]);
                obj.TespecificacionTecnica = Convert.ToString(dt.Rows[0][3]);
                obj.CcodUnidadMedida = Convert.ToString(dt.Rows[0][4]);
                obj.Fcantidad = Convert.ToDouble(dt.Rows[0][5]);
                obj.FprecioUnitario = Convert.ToDouble(dt.Rows[0][6]);
                obj.FprecioUnitario_Extranjero = Convert.ToDouble(dt.Rows[0][7]);
                obj.Fstock = Convert.ToDouble(dt.Rows[0][8]);
            }

            return obj;

        }

        public int Graba_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            int intIdRequerimiento_Detalle_Bien = 0;
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_ins_mvto_Requerimiento_Detalle_Bien",   obj.IidRequerimiento_Detalle,
                                                                                                                    obj.CcodMaterial,
                                                                                                                    obj.TespecificacionTecnica,
                                                                                                                    obj.CcodUnidadMedida,
                                                                                                                    obj.Fcantidad,
                                                                                                                    obj.FprecioUnitario,
                                                                                                                    obj.FprecioUnitario_Extranjero,
                                                                                                                    obj.Fstock
                                                          );
                intIdRequerimiento_Detalle_Bien = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch
            {
                intIdRequerimiento_Detalle_Bien = 0;
            }
            return intIdRequerimiento_Detalle_Bien;
        }

        public int Modifica_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            int intIdRequerimiento_Detalle_Bien = 0;
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_upd_mvto_Requerimiento_Detalle_Bien",   obj.IidRequerimiento_Detalle_Bien,
                                                                                                                    obj.CcodMaterial,
                                                                                                                    obj.TespecificacionTecnica,
                                                                                                                    obj.CcodUnidadMedida,
                                                                                                                    obj.Fcantidad,
                                                                                                                    obj.FprecioUnitario,
                                                                                                                    obj.FprecioUnitario_Extranjero,
                                                                                                                    obj.Fstock
                                                          );
                intIdRequerimiento_Detalle_Bien = obj.IidRequerimiento_Detalle_Bien;
            }
            catch
            {
                intIdRequerimiento_Detalle_Bien = 0;
            }
            return intIdRequerimiento_Detalle_Bien;
        }

        public int Elimina_Requerimiento_Detalle_Bien(int intIdRequerimiento_Detalle_Bien)
        {
            int intResultado = 0;

            try
            {
                intResultado = Convert.ToInt32(SqlHelper.ExecuteScalar(strConnection, "Gestion.spp_del_mvto_Requerimiento_Detalle_Bien", intIdRequerimiento_Detalle_Bien));

            }
            catch
            {
                intResultado = 0;
            }
            return intResultado;
        }

    }
}
