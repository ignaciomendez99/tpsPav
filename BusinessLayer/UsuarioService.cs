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

            if (usr.Password != null && usr.Password.Equals(password))
            {
                return usr;
            }

            return null;
        }

        internal void AgregarUsuario(Usuario usuario)
        {
            oUsuarioDao.InsertarUsuario(usuario);
        }

        public bool DeleteUsuarios(List<Usuario> usuarioList)
        {
            return oUsuarioDao.DeleteUsuarios(usuarioList);

        }

        public IList<Usuario> ObtenerUsuariosyEliminados()
        {
            return oUsuarioDao.GetAllYEliminados();

        }

        public bool checkUsuarioEliminado(Usuario usuario)
        {
            return oUsuarioDao.CheckUsuarioEliminado(usuario);
        }

        public List<Usuario> ObtenerUsuarioBuscadoEliminados(string busqueda)
        {
            return oUsuarioDao.GetUsuarioBySearchEliminados(busqueda);
        }

        public List<Usuario> ObtenerUsuarioBuscado(string busqueda)
        {
            return oUsuarioDao.GetUsuarioBySearch(busqueda);
        }

        public void modificarUsuario(Usuario usuarioAModificar)
        {
            oUsuarioDao.modificarUsuario(usuarioAModificar);
        }
    }
}
