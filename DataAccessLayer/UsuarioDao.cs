using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.Entities;

namespace TPS_PAV.DataAccessLayer
{
    class UsuarioDao
    {
        public IList<Usuario> GetAll()
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();

            var strSql = @"SELECT u.id_usuario, u.id_perfil, p.nombre as nombre_perfil, u.usuario, u.password, u.email, u.estado, u.borrado
                            from Usuarios u JOIN perfiles p ON u.id_perfil=p.id_perfil WHERE u.borrado = 0;";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuarios.Add(MappingBug(row));
            }

            return listadoUsuarios;
        }


        public IList<Usuario> ObtenerUsuariosCurso(Curso curso)
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();

            var strSql = @"SELECT u.*, p.nombre as nombre_perfil FROM usuarios u 
                            JOIN perfiles p ON p.id_perfil = u.id_perfil
                            JOIN UsuariosCurso uc ON u.id_usuario = uc.id_usuario WHERE uc.id_curso = @idcurso ;";

            Dictionary<string, object> sqlValues = new Dictionary<string, object>()
            {
                {"@idcurso", curso.IdCurso}
            };


            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, sqlValues);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuarios.Add(MappingBug(row));
            }

            return listadoUsuarios;
        }


        public Usuario GetUser(string pUsuario)
        {
            String consultaSql = string.Concat(" SELECT u.id_usuario, u.id_perfil, p.nombre as nombre_perfil, u.usuario, u.password, u.email, u.estado, u.borrado ",
                                               "   FROM Usuarios u JOIN perfiles p ON u.id_perfil=p.id_perfil ",
                                               "  WHERE usuario =  '", pUsuario, "'");

            var resultado = DataManager.GetInstance().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                return MappingBug(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Usuario> GetUsuarioByCurso(Curso curso)
        {
            var strSql = @"Select u.*, p.nombre AS nombre_perfil, p.id_perfil from usuarios u 
                            JOIN perfiles p ON u.id_perfil=p.id_perfil
                            JOIN usuarioscurso uc ON uc.id_usuario=u.id_usuario
                            where uc.id_curso = @idcurso AND u.borrado=0";


            Dictionary<string, object> sqlValues = new Dictionary<string, object>()
            {
                {"@idcurso", curso.IdCurso}
            };

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, sqlValues);

            List<Usuario> listUsuario = new List<Usuario>();
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listUsuario.Add(MappingBug(row));
            }

            return listUsuario;

        }

        public bool CheckUsuarioEliminado(Usuario usuario)
        {

            var strSql = "Select borrado from usuarios where id_usuario = @idusuario";


            Dictionary<string, object> sqlValues = new Dictionary<string, object>()
            {
                {"@idusuario", usuario.IdUsuario}
            };

            var res = Convert.ToInt32(DataManager.GetInstance().ConsultaSQLScalar(strSql, sqlValues));
            if (res == 1) return true;
            else return false;
        }

        public void modificarUsuario(Usuario usuarioAModificar)
        {

            var strSql = @"UPDATE usuarios SET usuario = @usuario, password = @password, email = @email, id_perfil = @id_perfil 
                            WHERE id_usuario = @idusuario";


            Dictionary<string, object> queryValues = new Dictionary<string, object>();
            queryValues.Add("@usuario", usuarioAModificar.NombreUsuario);
            queryValues.Add("@password", usuarioAModificar.Password);
            queryValues.Add("@email", usuarioAModificar.Email);
            queryValues.Add("@id_perfil", usuarioAModificar.Perfil.IdPerfil);
            queryValues.Add("@idusuario", usuarioAModificar.IdUsuario);

            DataManager.GetInstance().EjecutarSQL(strSql, queryValues);
        }

        public List<Usuario> GetUsuarioBySearchEliminados(object searchParam)
        {

            List<Usuario> listUsuario = new List<Usuario>();

            var strSql = @"SELECT u.id_usuario, u.id_perfil, p.nombre as nombre_perfil, u.usuario, u.password, u.email, u.estado, u.borrado
                            from Usuarios u JOIN perfiles p ON u.id_perfil=p.id_perfil WHERE (u.usuario LIKE @search );";


            Dictionary<string, object> dictSql = new Dictionary<string, object>();

            dictSql.Add("@search", "%" + searchParam + "%");

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, dictSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listUsuario.Add(MappingBug(row));
            }

            return listUsuario;
        }

        public IList<Usuario> GetAllYEliminados()
        {
            List<Usuario> listUsuario = new List<Usuario>();

            var strSql = @"SELECT u.id_usuario, u.id_perfil, p.nombre as nombre_perfil, u.usuario, u.password, u.email, u.estado, u.borrado
                            from Usuarios u JOIN perfiles p ON u.id_perfil=p.id_perfil;";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listUsuario.Add(MappingBug(row));
            }

            return listUsuario;
        }

        public List<Usuario> GetUsuarioBySearch(object searchParam)
        {

            List<Usuario> listUsuario = new List<Usuario>();

            var strSql = @"SELECT u.id_usuario, u.id_perfil, p.nombre as nombre_perfil, u.usuario, u.password, u.email, u.estado, u.borrado
                            from Usuarios u JOIN perfiles p ON u.id_perfil=p.id_perfil WHERE (u.usuario LIKE @search) AND u.borrado = 0;";

            Dictionary<string, object> dictSql = new Dictionary<string, object>();

            dictSql.Add("@search", "%" + searchParam + "%");

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, dictSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listUsuario.Add(MappingBug(row));
            }

            return listUsuario;
        }

        public bool DeleteUsuarios(List<Usuario> usuarioList)
        {
            DataManager dm = DataManager.GetInstance();

            bool success = false;
            try
            {
                dm.BeginTransaction();
                foreach(Usuario usuario in usuarioList)
                {
                    var sqlQuery = "UPDATE usuarios SET borrado = 1 WHERE id_usuario = @idusuario";
                    Dictionary<string, object> queryValues = new Dictionary<string, object>();

                    queryValues.Add("@idusuario", usuario.IdUsuario);

                    dm.EjecutarSQL(sqlQuery, queryValues);
                }

                dm.Commit();
                success = true;


            }

            catch (Exception e)
            {
                dm.Rollback();

            }

            return success;        }

        private Usuario MappingBug(DataRow row)
        {
            System.Console.WriteLine();
            Usuario oUsuario = new Usuario 
            {
                IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                NombreUsuario = row["usuario"].ToString(),
                Perfil = new Perfil { IdPerfil = Int32.Parse(row["id_perfil"].ToString()), Nombre = row["nombre_perfil"].ToString() },
                Email = row["email"].ToString(),
                Estado = row["estado"].ToString(),
                Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null
            };

            return oUsuario;
        }


        public void InsertarUsuario(Usuario usuario)
        {

            var sqlQuery = @"INSERT INTO usuarios( id_perfil, usuario, password, email, estado,borrado)
                            VALUES ( @idperfil, @usuario, @password,@email,@estado,@borrado)";
            Dictionary<string, object> queryValues = new Dictionary<string, object>();

            //queryValues.Add("@idusuario", GetLastIdCurso() + 1);
            queryValues.Add("@idperfil", usuario.Perfil.IdPerfil);
            queryValues.Add("@usuario", usuario.NombreUsuario);
            queryValues.Add("@password", usuario.Password);
            queryValues.Add("@email", usuario.Email);
            queryValues.Add("@estado", "S");
            queryValues.Add("@borrado", 0);

            DataManager.GetInstance().EjecutarSQL(sqlQuery, queryValues);

        }

        private int GetLastIdCurso()
        {

            var sqlQuery = "SELECT MAX(id_usuario) FROM usuarios";
            var lastID = DataManager.GetInstance().ConsultaSQLScalar(sqlQuery);
            if (lastID is System.DBNull)
            // La consulta SQL Scalar devuelve DBNull en caso de Null.
            {
                return 0;
            }
            return (int)lastID;

        }


    }
}
