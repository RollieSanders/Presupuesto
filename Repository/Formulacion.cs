using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class Formulacion
    {
        private string strConnection_Formulacion = "";
        public Formulacion()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection_Formulacion = DA.ReturnConnectionString_Formulacion();
        }

        public DataSet Ayuda_Formulacion(string strCodCompañia,
                                         string strAñoProceso,
                                         string strCodCentroCosto_Gestor,
                                         string strCodFuenteFinanciamiento,
                                         string strCodCentroCosto,
                                         string strCodProyecto,
                                         string strCodTipoAdquisicion
                                       )
        {
            DataSet ds = new DataSet();
            using (ds = SqlHelper.ExecuteDataset(strConnection_Formulacion, "Formulacion.spp_help_mvto_Formulacion", strCodCompañia, 
                                                                                                                     strAñoProceso,
                                                                                                                     strCodCentroCosto_Gestor,
                                                                                                                     strCodFuenteFinanciamiento,
                                                                                                                     strCodCentroCosto,
                                                                                                                     strCodProyecto,
                                                                                                                     strCodTipoAdquisicion
                                                                                                                     ))
            {
                return ds;
            }
        }
    }
}
