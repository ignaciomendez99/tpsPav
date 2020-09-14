using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.DataAccessLayer;
using TPS_PAV.Entities;

namespace TPS_PAV.BusinessLayer
{
    class UsuarioService
    {
        private UsuarioDao oUsuarioDao;
        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }
        public IList<Usuario> ObtenerTodos()
        {
            return oUsuarioDao.GetAll();
        }

        public Usuario ValidarUsuario(string usuario, string password)
        {
            var usr = oUsuarioDao.GetUser(usuario);

            if (usr == null)
            {
                return null;
            }

            // validar username

            if (usr.Password != null && usr.Password.Equals(password))
            {
                return usr;
            }

            return null;
        }

    }
}
