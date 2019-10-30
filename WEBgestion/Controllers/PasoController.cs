using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBgestion.Controllers
{
    public class PasoController : ApiController
    {
        [HttpGet]
        [Route("api/Paso/{strNumRequerimiento}")]
        public Model.Paso_Requerimiento GetPaso(    string strNumRequerimiento
            )
        {
            Repository.Paso_Requerimiento objRES = new Repository.Paso_Requerimiento();
            return objRES.GetPaso_Requerimiento(strNumRequerimiento);
        }
    }
}
