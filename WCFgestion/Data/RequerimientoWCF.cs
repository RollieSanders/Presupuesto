using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace WCFgestion.Data
{
    public class RequerimientoWCF
    {
        private string strConnection;
        public RequerimientoWCF()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Formulacion();
        }

        public Modelo.RequerimientoWCF Recupera_Requerimiento(string strNumRequerimiento)
        {
            DataTable dt = new DataTable();


            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_lst_mvto_Requerimiento_Detalle_Requerimiento_Smart", strNumRequerimiento);

            Modelo.RequerimientoWCF objMES = new Modelo.RequerimientoWCF();

            foreach (DataRow row in dt.Rows)
            {
                objMES = GetEmpDataTableRow(row);
            }

            return objMES;
        }

        public List<Modelo.RequerimientoWCF> Lista_Requerimiento(string strCodCentroCosto_Gestor)
        {
            DataTable dt = new DataTable();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Gestion.spp_lst_mvto_Requerimiento_Detalle_CentroCosto_Gestor_Smart", strCodCentroCosto_Gestor);
            List<Modelo.RequerimientoWCF> ListaobjMES = new List<Modelo.RequerimientoWCF>();
            ListaobjMES = new List<Modelo.RequerimientoWCF>(
                           (from dRow in dt.AsEnumerable()
                            select (GetEmpDataTableRow(dRow)))
                           );


            return ListaobjMES;
        }
        private Modelo.RequerimientoWCF GetEmpDataTableRow(DataRow dr)
        {
            Modelo.RequerimientoWCF objMES = new Modelo.RequerimientoWCF();

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

            return (objMES);
        }

    }
}