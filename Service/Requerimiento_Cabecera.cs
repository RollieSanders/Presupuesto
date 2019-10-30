using System;
using System.Data;

namespace Service
{
    public class Requerimiento_Cabecera
    {
        public Model.Requerimiento_Cabecera Recupera_Requerimiento_Cabecera(int intIdRequrimiento_Cabecera)
        {
            Repository.Requerimiento_Cabecera objDs = new Repository.Requerimiento_Cabecera();
            return objDs.Recupera_Requerimiento_Cabecera(intIdRequrimiento_Cabecera);

        }

        public Model.Requerimiento_Cabecera Graba_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {
            Repository.Requerimiento_Cabecera objDs = new Repository.Requerimiento_Cabecera();
            return objDs.Graba_Requerimiento_Cabecera(obj);
        }

        public int Modifica_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {
            Repository.Requerimiento_Cabecera objDs = new Repository.Requerimiento_Cabecera();
            return objDs.Modifica_Requerimiento_Cabecera(obj);
        }

        public int Elimina_Requerimiento_Cabecera(int intIdRequerimiento_Cabecera)
        {
            Repository.Requerimiento_Cabecera objDs = new Repository.Requerimiento_Cabecera();
            return objDs.Elimina_Requerimiento_Cabecera(intIdRequerimiento_Cabecera);
        }

        public DataTable Combo_AñoProceso(string strCodCompañia)
        {
            Repository.Formulacion_Cabecera objDs = new Repository.Formulacion_Cabecera();
            return objDs.Combo_AñoProceso(strCodCompañia);
        }
    }
}
