using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Requerimiento
    {
        //public Model.Requerimiento Recupera_Requerimiento(string strNumRequerimiento)
        //{
        //    Repository.Requerimiento objDs = new Repository.Requerimiento();

        //    return objDs.Recupera_Requerimiento(strNumRequerimiento);
        //}

        //public List<Model.Requerimiento> Lista_Requerimiento(string strCodCentroCosto_Gestor)
        //{
        //    Repository.Requerimiento objDs = new Repository.Requerimiento();
        //    return objDs.Lista_Requerimiento(strCodCentroCosto_Gestor);
        //}

        public Model.Formulacion_Saldo Recupera_Formulacion_Sado( Model.Formulacion_Saldo obj )
        {
            Repository.Requerimiento objDs = new Repository.Requerimiento();
            return objDs.Recupera_Formulacion_Sado(obj);
        }

    }
}
