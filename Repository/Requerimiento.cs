using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Collections.Generic;

namespace Repository
{
    public class Requerimiento
    {
        private string strConnection;
        public Requerimiento()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Formulacion();
        }

        public Model.Requerimiento GetRequerimiento(string strNumRequerimiento)
        {
            DataTable dt = new DataTable();


            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_lst_mvto_Requerimiento_Detalle_Requerimiento_Smart", strNumRequerimiento);

            Model.Requerimiento objMES = new Model.Requerimiento();

            foreach (DataRow row in dt.Rows)
            {
                objMES = GetEmpDataTableRow(row);
            }

            return objMES;
        }

        public List<Model.Requerimiento> GetListaRequerimiento(string strCodCentroCosto_Gestor)
        {
            DataTable dt = new DataTable();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_lst_mvto_Requerimiento_Detalle_CentroCosto_Gestor_Smart", strCodCentroCosto_Gestor);
            List<Model.Requerimiento> ListaobjMES = new List<Model.Requerimiento>();
            ListaobjMES = new List<Model.Requerimiento>(
                           (from dRow in dt.AsEnumerable()
                            select (GetEmpDataTableRow(dRow)))
                           );


            return ListaobjMES;
        }

        private Model.Requerimiento GetEmpDataTableRow(DataRow dr)
        {
            Model.Requerimiento objMES = new Model.Requerimiento();

            objMES.CnumRequerimiento = Convert.ToString(dr["CnumRequerimiento"]);
            objMES.DfecRequerimiento = Convert.ToDateTime(dr["DfecRequerimiento"]);
            objMES.Tnota = Convert.ToString(dr["Tnota"]);
            objMES.cCodFuenteFinanciamiento = Convert.ToString(dr["cCodFuenteFinanciamiento"]);
            objMES.vNomFuenteFinanciamiento = Convert.ToString(dr["vNomFuenteFinanciamiento"]);
            objMES.CcodCeCo = Convert.ToString(dr["CcodCeCo"]);
            objMES.vNomCeCo = Convert.ToString(dr["vNomCeCo"]);
            objMES.CcodProyecto = Convert.ToString(dr["CcodProyecto"]);
            objMES.vNomCortoProyecto = Convert.ToString(dr["vNomCortoProyecto"]);
            objMES.CcodPosPre = Convert.ToString(dr["CcodPosPre"]);
            objMES.vNomPosPre = Convert.ToString(dr["vNomPosPre"]);
            objMES.CcodClasificador = Convert.ToString(dr["CcodClasificador"]);
            objMES.vNomClasificador = Convert.ToString(dr["vNomClasificador"]);
            objMES.CcodTipoGasto = Convert.ToString(dr["CcodTipoGasto"]);
            objMES.vNomClaseGasto = Convert.ToString(dr["vNomClaseGasto"]);
            objMES.FimporteTotal = Convert.ToDouble(dr["FimporteTotal"]);
            objMES.cPaso = Convert.ToString(dr["cPaso"]);

            return (objMES);
        }



        


        public Model.Formulacion_Saldo Recupera_Formulacion_Sado(   Model.Formulacion_Saldo obj )
        {
            DataTable dt = new DataTable();


            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_sel_mvto_Formulacion_Saldo", obj.CañoProceso,
                                                                                                     obj.CcodFuenteFinanciamiento,
                                                                                                     obj.CcodCeCo_Gestor,
                                                                                                     obj.CcodProyecto,
                                                                                                     obj.CcodPosPre,
                                                                                                     obj.CcodClasificador,
                                                                                                     obj.CcodTipoGasto
                                            );

            Model.Formulacion_Saldo objMES = new Model.Formulacion_Saldo();

            foreach (DataRow row in dt.Rows)
            {
                objMES = GetSalDataTableRow(row);
            }

            return objMES;
        }

        //public List<Model.Requerimiento> GetListaRequerimiento(string strCodCentroCosto_Gestor)
        //{
        //    DataTable dt = new DataTable();

        //    dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_lst_mvto_Requerimiento_Detalle_CentroCosto_Gestor_Smart", strCodCentroCosto_Gestor);
        //    List<Model.Requerimiento> ListaobjMES = new List<Model.Requerimiento>();
        //    ListaobjMES = new List<Model.Requerimiento>(
        //                   (from dRow in dt.AsEnumerable()
        //                    select (GetEmpDataTableRow(dRow)))
        //                   );


        //    return ListaobjMES;
        //}

        private Model.Formulacion_Saldo GetSalDataTableRow(DataRow dr)
        {
            Model.Formulacion_Saldo objMES = new Model.Formulacion_Saldo();


            objMES.CcodFuenteFinanciamiento = Convert.ToString(dr["CcodFuenteFinanciamiento"]);
            objMES.CcodCeCo_Gestor = Convert.ToString(dr["CcodCeCo_Gestor"]);
            objMES.CcodProyecto = Convert.ToString(dr["CcodProyecto"]);
            objMES.CcodPosPre = Convert.ToString(dr["CcodPosPre"]);
            objMES.CcodClasificador = Convert.ToString(dr["CcodClasificador"]);
            objMES.CcodTipoGasto = Convert.ToString(dr["CcodTipoGasto"]);
            objMES.fFormulado = Convert.ToDouble(dr["fFormulado"]);
            objMES.FimporteComprometido = Convert.ToDouble(dr["FimporteComprometido"]);
            objMES.FimporteEjecutado = Convert.ToDouble(dr["FimporteEjecutado"]);

            return (objMES);
        }







    }
}
