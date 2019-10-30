using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBgestion.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpGet]
        [Route("api/Usuario/{strLogUsuario}")]
        public Model.Usuario GetUsuario(string strLogUsuario)
        {
            Repository.Usuario objRES = new Repository.Usuario();
            return objRES.GetUsuario(strLogUsuario);
        }
    }
}
