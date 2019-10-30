using System;
using System.Data;

namespace Service
{
    public class Requerimiento_Detalle_Bien
    {
        public Model.Requerimiento_Detalle_Bien Recupera_Requerimiento_Detalle_Bien(int intIdRequrimiento_Detalle_Bien)
        {
            Repository.Requerimiento_Detalle_Bien objDs = new Repository.Requerimiento_Detalle_Bien();
            return objDs.Recupera_Requerimiento_Detalle_Bien(intIdRequrimiento_Detalle_Bien);

        }

        public int Graba_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            Repository.Requerimiento_Detalle_Bien objDs = new Repository.Requerimiento_Detalle_Bien();
            return objDs.Graba_Requerimiento_Detalle_Bien(obj);
        }

        public int Modifica_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            Repository.Requerimiento_Detalle_Bien objDs = new Repository.Requerimiento_Detalle_Bien();
            return objDs.Modifica_Requerimiento_Detalle_Bien(obj);
        }

        public int Elimina_Requerimiento_Detalle_Bien(int intIdRequerimiento_Detalle_Bien)
        {
            Repository.Requerimiento_Detalle_Bien objDs = new Repository.Requerimiento_Detalle_Bien();
            return objDs.Elimina_Requerimiento_Detalle_Bien(intIdRequerimiento_Detalle_Bien);
        }
    }
}
