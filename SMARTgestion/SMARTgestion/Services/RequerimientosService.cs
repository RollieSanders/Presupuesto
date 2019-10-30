using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SMARTgestion.Data;
using SMARTgestion.Models;

namespace SMARTgestion.Services
{
    public class RequerimientosService
    {
        private RequerimientosRepository _requerimientosRepository;
        public RequerimientosService()
        {
            _requerimientosRepository = new RequerimientosRepository();
        }

        public List<Requerimientos> GetRequerimientos(string requerimientosApiUrl)
        {
            return _requerimientosRepository.GetRequerimientos(requerimientosApiUrl);
        }
    }
}
