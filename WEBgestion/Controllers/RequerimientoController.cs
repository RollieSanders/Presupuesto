using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBgestion.Controllers
{
    public class RequerimientoController : ApiController
    {
        [HttpGet]
        [Route("api/Requerimiento/{strNumRequerimiento}")]
        public Model.Requerimiento GetRequerimiento(string strNumRequerimiento )
        {
            Repository.Requerimiento objRES = new Repository.Requerimiento();
            return objRES.GetRequerimiento( strNumRequerimiento );
        }
    }
}
