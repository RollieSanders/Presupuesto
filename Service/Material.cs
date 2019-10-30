using System;
using System.Data;

namespace Service
{
    public class Material
    {
        public Model.Material Recupera_Material(string strCodMaterial)
        {
            Repository.Material ds = new Repository.Material();
            return ds.Recupera_Material(strCodMaterial);
        }

        public Model.Servicio Recupera_Servicio(string strCodServicio)
        {
            Repository.Material ds = new Repository.Material();
            return ds.Recupera_Servicio(strCodServicio);
        }

        public DataSet Ayuda_Material(string strTexto)
        {
            Repository.Material ds = new Repository.Material();
            return ds.Ayuda_Material(strTexto);
        }

        public DataSet Ayuda_Servicio( string strCodPosPre  )
        {
            Repository.Material ds = new Repository.Material();
            return ds.Ayuda_Servicio( strCodPosPre  );
        }
    }
}
