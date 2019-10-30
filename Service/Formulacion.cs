using System;
using System.Data;

namespace Service
{
    public class Formulacion
    {
        public DataSet Ayuda_Formulacion(string strCodCompañia,
                                         string strAñoProceso,
                                         string strCodCentroCosto_Gestor,
                                         string strCodFuenteFinanciamiento,
                                         string strCodCentroCosto,
                                         string strCodProyecto,
                                         string strCodTipoAdquisicion
                                       )
        {
            Repository.Formulacion objDs = new Repository.Formulacion();
            return objDs.Ayuda_Formulacion(strCodCompañia,
                                           strAñoProceso,
                                           strCodCentroCosto_Gestor,
                                           strCodFuenteFinanciamiento,
                                           strCodCentroCosto,
                                           strCodProyecto,
                                           strCodTipoAdquisicion
                                          );
        }
    }
}
