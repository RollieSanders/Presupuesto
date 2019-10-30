using System;
using System.Data;

namespace Service
{
    public class Requerimiento_Detalle_Servicio
    {
        public Model.Requerimiento_Detalle_Servicio Recupera_Requerimiento_Detalle_Servicio(int intIdRequrimiento_Cabecera)
        {
            Repository.Requerimiento_Detalle_Servicio objDs = new Repository.Requerimiento_Detalle_Servicio();
            return objDs.Recupera_Requerimiento_Detalle_Servicio(intIdRequrimiento_Cabecera);

        }

        public int Graba_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            Repository.Requerimiento_Detalle_Servicio objDs = new Repository.Requerimiento_Detalle_Servicio();
            return objDs.Graba_Requerimiento_Detalle_Servicio(obj);
        }

        public int Modifica_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            Repository.Requerimiento_Detalle_Servicio objDs = new Repository.Requerimiento_Detalle_Servicio();
            return objDs.Modifica_Requerimiento_Detalle_Servicio(obj);
        }

        public int Elimina_Requerimiento_Detalle_Servicio(int intIdRequerimiento_Detalle_Servicio)
        {
            Repository.Requerimiento_Detalle_Servicio objDs = new Repository.Requerimiento_Detalle_Servicio();
            return objDs.Elimina_Requerimiento_Detalle_Servicio(intIdRequerimiento_Detalle_Servicio);
        }
    }
}
