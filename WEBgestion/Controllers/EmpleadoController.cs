using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBgestion.Controllers
{
    public class EmpleadoController : ApiController
    {
        [HttpGet]
        [Route("api/Empleado/{strCodEmpleado}")]
        public Model.Empleado GetEmpleado(string strCodEmpleado)
        {
            Repository.Empleado objRES = new Repository.Empleado();
            return objRES.GetEmpleado(strCodEmpleado);
        }
    }
}
