using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBgestion.Controllers
{
    public class RequerimientosController : ApiController
    {

        [HttpGet]
        [Route("api/Requerimientos/{strCodCentroCosto_Gestor}")]
        public List<Model.Requerimiento> GetRequerimientos(string strCodCentroCosto_Gestor)
        {
            Repository.Requerimiento objRES = new Repository.Requerimiento();
            return objRES.GetListaRequerimiento(strCodCentroCosto_Gestor);
        }
    }
}
