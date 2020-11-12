using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.DataAccessLayer;
using TPS_PAV.Entities;

namespace TPS_PAV.BusinessLayer
{
    class PerfilService
    {
        private readonly PerfilDAO oPerfilDAO;
        
        public PerfilService()
        {
            oPerfilDAO = new PerfilDAO();
        }

        public IList<Perfil> ObtenerTodos()
        {
            return oPerfilDAO.GetAll();
        }


    }
}
