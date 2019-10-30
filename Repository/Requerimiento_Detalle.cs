using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class Requerimiento_Detalle
    {
        private string strConnection = "";
        public Requerimiento_Detalle()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Formulacion();
        }

        public Model.Requerimiento_Detalle Recupera_Requerimiento_Detalle(int intIdRequrimiento_Detalle )
        {
            DataTable dt = new DataTable();
            Model.Requerimiento_Detalle obj = new Model.Requerimiento_Detalle();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_sel_mvto_Requerimiento_Detalle", intIdRequrimiento_Detalle );

            if (dt.Rows.Count == 0)
            {
                obj.IidRequerimiento_Cabecera = 0;
                obj.IidRequerimiento_Detalle = 0;
                obj.CcodFuenteFinanciamiento = "";
                obj.CcodCeCo = "";
                obj.CcodProyecto = "";
                obj.CcodComponente = "";

                obj.CcodPosPre = "";
                obj.CcodClasificador  = "";
                obj.CcodTipoGasto  = "";
                obj.FimporteTotal = 0.0;
            }
            else
            {
                obj.IidRequerimiento_Cabecera = Convert.ToInt32(dt.Rows[0][0]);
                obj.IidRequerimiento_Detalle = Convert.ToInt32(dt.Rows[0][1]);
                obj.CcodFuenteFinanciamiento = Convert.ToString(dt.Rows[0][2]);
                obj.CcodCeCo = Convert.ToString(dt.Rows[0][3]);
                obj.CcodProyecto = Convert.ToString(dt.Rows[0][4]);
                obj.CcodComponente = Convert.ToString(dt.Rows[0][5]);

                obj.CcodPosPre = Convert.ToString(dt.Rows[0][6]);
                obj.CcodClasificador = Convert.ToString(dt.Rows[0][7]);
                obj.CcodTipoGasto = Convert.ToString(dt.Rows[0][8]);
                obj.FimporteTotal = Convert.ToInt32(dt.Rows[0][9]);
            }

            return obj;

        }

        public int Graba_Requerimiento_Detalle(Model.Requerimiento_Detalle obj)
        {
            int intIdRequerimiento_Detalle = 0;
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_ins_mvto_Requerimiento_Detalle", obj.IidRequerimiento_Cabecera,
                                                                                                            obj.CcodFuenteFinanciamiento,
                                                                                                            obj.CcodCeCo,
                                                                                                            obj.CcodProyecto,
                                                                                                            obj.CcodComponente,
                                                                                                            obj.CcodPosPre,
                                                                                                            obj.CcodClasificador,
                                                                                                            obj.CcodTipoGasto,
                                                                                                            obj.FimporteTotal
                                                          );
                intIdRequerimiento_Detalle = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch
            {
                intIdRequerimiento_Detalle = 0;
            }
            return intIdRequerimiento_Detalle;
        }

        public int Modifica_Requerimiento_Detalle(Model.Requerimiento_Detalle obj)
        {
            int intIdRequerimiento_Detalle = 0;
            DataTable dt = new DataTable();
            try
            {
                dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_uod_mvto_Requerimiento_Detalle", obj.IidRequerimiento_Detalle,
                                                                                                            obj.CcodFuenteFinanciamiento,
                                                                                                            obj.CcodCeCo,
                                                                                                            obj.CcodProyecto,
                                                                                                            obj.CcodComponente,
                                                                                                            obj.CcodPosPre,
                                                                                                            obj.CcodClasificador,
                                                                                                            obj.CcodTipoGasto,
                                                                                                            obj.FimporteTotal
                                                          );
                intIdRequerimiento_Detalle = obj.IidRequerimiento_Detalle;
            }
            catch
            {
                intIdRequerimiento_Detalle = 0;
            }
            return intIdRequerimiento_Detalle;
        }

        public int Elimina_Requerimiento_Detalle(int intIdRequerimiento_Detalle)
        {
            int intResultado = 0;

            try
            {
                intResultado = Convert.ToInt32(SqlHelper.ExecuteScalar(strConnection, "Gestion.spp_del_mvto_Requerimiento_Detalle", intIdRequerimiento_Detalle));

            }
            catch
            {
                intResultado = 0;
            }
            return intResultado;
        }

        public DataSet Lista_Requerimiento_Detalle( string strNumRequerimiento  )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Requerimiento_Detalle", strNumRequerimiento);
            return ds;
        }

        public DataSet Lista_EjecucionPresupuestal_CentroCosto(string strAñoProceso, string strCodCentroCosto_Gestor )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_EjecucionPresupuestal_CentroCosto", strAñoProceso, strCodCentroCosto_Gestor);
            return ds;
        }

        public DataSet Lista_EjecucionPresupuestal_Proyecto(string strAñoProceso, string strCodProyecto)
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_EjecucionPresupuestal_Proyecto", strAñoProceso, strCodProyecto);
            return ds;
        }


        public DataSet Lista_Requerimiento_Detalle_Requerido( Model.Formulacion_Saldo obj)
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_sel_mvto_Requerimiento_Detalle_Requerido", obj.CañoProceso,
                                                                                                                 obj.CcodFuenteFinanciamiento,
                                                                                                                 obj.CcodCeCo_Gestor,
                                                                                                                 obj.CcodProyecto,
                                                                                                                 obj.CcodPosPre,
                                                                                                                 obj.CcodClasificador,
                                                                                                                 obj.CcodTipoGasto
                                                                                                                 );
            return ds;
        }

        public DataSet Lista_Requerimiento_Detalle_Ejecutado(Model.Formulacion_Saldo obj)
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_sel_mvto_Requerimiento_Detalle_Ejecutado", obj.CañoProceso,
                                                                                                                 obj.CcodFuenteFinanciamiento,
                                                                                                                 obj.CcodCeCo_Gestor,
                                                                                                                 obj.CcodProyecto,
                                                                                                                 obj.CcodPosPre,
                                                                                                                 obj.CcodClasificador,
                                                                                                                 obj.CcodTipoGasto
                                                                                                                 );
            return ds;
        }

        public DataSet Lista_Formulado_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Formulado_CentroCosto", strAñoProceso,
                                                                                                       strCodCentroCosto_Gestor,
                                                                                                       strCodCentroCosto,
                                                                                                       strCodClasificador
                                         );
            return ds;
        }

        public DataSet Lista_Disponible_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Disponible_CentroCosto", strAñoProceso,
                                                                                                       strCodCentroCosto_Gestor,
                                                                                                       strCodCentroCosto,
                                                                                                       strCodClasificador
                                         );
            return ds;
        }

        public DataSet Lista_Ejecutado_CentroCosto( string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Ejecutado_CentroCosto", strAñoProceso,
                                                                                                       strCodCentroCosto_Gestor,
                                                                                                       strCodCentroCosto,
                                                                                                       strCodClasificador
                                         );
            return ds;
        }

        public DataSet Lista_Comprometido_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Comprometido_CentroCosto", strAñoProceso,
                                                                                                       strCodCentroCosto_Gestor,
                                                                                                       strCodCentroCosto,
                                                                                                       strCodClasificador
                                         );
            return ds;
        }


        public DataSet Lista_Formulado_Proyecto(string strAñoProceso,
                                            string strCodProyecto,
                                            string strCodClasificador
                                          )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Formulado_Proyecto", strAñoProceso,
                                                                                                       strCodProyecto,
                                                                                                       strCodClasificador
                                         );
            return ds;
        }

        public DataSet Lista_Disponible_Proyecto(string strAñoProceso,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Disponible_Proyecto", strAñoProceso,
                                                                                                       strCodProyecto,
                                                                                                       strCodClasificador
                                         );
            return ds;
        }

        public DataSet Lista_Ejecutado_Proyecto(string strAñoProceso,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Ejecutado_Proyecto", strAñoProceso,
                                                                                                       strCodProyecto,
                                                                                                       strCodClasificador
                                         );
            return ds;
        }

        public DataSet Lista_Comprometido_Proyecto(string strAñoProceso,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Comprometido_Proyecto", strAñoProceso,
                                                                                                       strCodProyecto,
                                                                                                       strCodClasificador
                                         );
            return ds;
        }













        public DataSet Formato_Requerimiento(string strNumRequerimiento )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Requerimiento_Detalle_Requerimiento", strNumRequerimiento
                                                                                                                 );
            return ds;
        }

        public DataSet Formato_Requerimiento_Estado(string strCodCentro_Gestor,
                                                    string strEstado,
                                                    string strCodEmpleado
                                                   )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Requerimiento_Detalle_CentroCosto_Gestor", strCodCentro_Gestor, 
                                                                                                                          strEstado,
                                                                                                                          strCodEmpleado
                                                                                                                 );
            return ds;
        }

        public DataSet Formato_Requerimiento_Ceco(string strCodCentro_Gestor,
                                                    string strEstado,
                                                    string strCodEmpleado
                                                   )
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(strConnection, "Gestion.spp_lst_mvto_Requerimiento_Detalle_CentroCosto", strCodCentro_Gestor,
                                                                                                                          strEstado,
                                                                                                                          strCodEmpleado
                                                                                                                 );
            return ds;
        }

        public Boolean Formato_Requerimiento_Firma(string strCodCentro_Gestor,
                                                    string strPaso,
                                                    string strNumRequerimiento
                                                   )
        {
            Boolean blnResult = true;
            try
            {
                SqlHelper.ExecuteNonQuery(strConnection, "Gestion.spp_ins_mvto_Requerimiento_Firma", strCodCentro_Gestor,
                                                                                                   strPaso,
                                                                                                   strNumRequerimiento
                                                                                           );
            }
            catch (Exception)
            {

                blnResult = false;
            }

            return blnResult;
        }

        public Boolean Formato_Requerimiento_DescarteFirma(string strCodCentro_Gestor,
                                            string strPaso,
                                            string strNumRequerimiento,
                                            string strMotivoDescarte
                                           )
        {
            Boolean blnResult = true;
            try
            {
                SqlHelper.ExecuteNonQuery(strConnection, "Gestion.spp_ins_mvto_Requerimiento_DescarteFirma", strCodCentro_Gestor,
                                                                                                   strPaso,
                                                                                                   strNumRequerimiento,
                                                                                                   strMotivoDescarte
                                                                                           );
            }
            catch (Exception)
            {

                blnResult = false;
            }

            return blnResult;
        }



    }
}
