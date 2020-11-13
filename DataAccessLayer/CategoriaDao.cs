using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.Entities;

namespace TPS_PAV.DataAccessLayer
{
    class CategoriaDao
    {
        
        public IList<Categoria> GetAll()
        {
            List<Categoria> listCategorias = new List<Categoria>();

            var strSql = "SELECT * from Categorias WHERE borrado = 0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listCategorias.Add(MappingCategoria(row));
            }

            return listCategorias;
        }

        public bool DeleteCategorias (IList<Categoria> catList)
        {
            DataManager dm = DataManager.GetInstance();

            bool succes = false;
            try
            {
                dm.BeginTransaction();


                foreach (Categoria objt in catList)
                {

                    var sqlQuery = "UPDATE Categorias SET borrado = 1 WHERE id_categoria = @idcategoria";

                    Dictionary<string, object> queryValuesAdd = new Dictionary<string, object>();
                    queryValuesAdd.Add("@idcategoria", objt.IdCategoria);

                    dm.EjecutarSQL(sqlQuery, queryValuesAdd);

                }


                dm.Commit();
                succes = true;
            }
            catch (Exception ex)
            {
                dm.Rollback();
            }

            return succes;

        }

        public void ModificarCategoria(Categoria cat)
        {
            var sqlQuery = "UPDATE Categorias SET nombre = @nombre, descripcion = @descripcion WHERE id_categoria = @idcategoria";

            Dictionary<string, object> queryValues = new Dictionary<string, object>();

            queryValues.Add("@nombre", cat.Nombre);
            queryValues.Add("@descripcion", cat.Descripcion);
            queryValues.Add("@idcategoria", cat.IdCategoria);

            DataManager.GetInstance().EjecutarSQL(sqlQuery, queryValues);
        }

        private Categoria MappingCategoria(DataRow row)
        {
            Categoria oCategoria = new Categoria
            {
                IdCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString()
               
            };

            return oCategoria;
        }


        public bool CheckCategoriaEliminado(Categoria cat)
        {
            var strSql = "Select borrado from Categorias where id_categoria = @idCategoria";
            Dictionary<string, object> sqlValues = new Dictionary<string, object>()
            {
                {"@idCategoria", cat.IdCategoria}
            };

            var res = Convert.ToInt32(DataManager.GetInstance().ConsultaSQLScalar(strSql, sqlValues));
            if (res == 1) return true;
            else return false;
        }

        public IList<Categoria> GetCategoriaBySearchEliminados(string searchParam)
        {
            List<Categoria> listObjetivo = new List<Categoria>();

            var strSql = "SELECT * from Categorias WHERE (nombre LIKE @search " +
                         "OR descripcion LIKE @search); ";


            Dictionary<string, object> dictSql = new Dictionary<string, object>();

            dictSql.Add("@search", "%" + searchParam + "%");

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, dictSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listObjetivo.Add(MappingCategoria(row));
            }

            return listObjetivo;
        }

        public IList<Categoria> GetCategoriaBySearch(string searchParam)
        {

            List<Categoria> listObjetivo = new List<Categoria>();

            var strSql = "SELECT * from Categorias WHERE (nombre LIKE @search " +
                         "OR descripcion LIKE @search) AND borrado = 0; ";

            Dictionary<string, object> dictSql = new Dictionary<string, object>();

            dictSql.Add("@search", "%" + searchParam + "%");

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, dictSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listObjetivo.Add(MappingCategoria(row));
            }

            return listObjetivo;

        }

        public void InsertCategoria(Categoria cat)
        {

            var sqlQuery = "INSERT INTO Categorias (id_categoria, nombre, descripcion, borrado) VALUES (@idcategoria, @nom, @desc,@borrado)";
            Dictionary<string, object> queryValues = new Dictionary<string, object>();

            queryValues.Add("@idcategoria", cat.IdCategoria + 1);
            queryValues.Add("@nom", cat.Nombre);
            queryValues.Add("@desc", cat.Descripcion);
            queryValues.Add("@borrado", 0);

            DataManager.GetInstance().EjecutarSQL(sqlQuery, queryValues);

        }

        public IList<Categoria> GetAllYEliminados()
        {
            List<Categoria> lista = new List<Categoria>();

            var strSql = "SELECT * FROM Categorias;";

            var res = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in res.Rows)
            {
                lista.Add(MappingCategoria(row));

            }
            return lista;

        }

        public Categoria getCategoriaById(int idCategoria)
        {

            var sqlQuery = "SELECT * FROM Categorias WHERE id_categoria = @idcategoria ";
            Dictionary<string, object> queryValues = new Dictionary<string, object>();
            queryValues.Add("@idcategoria", idCategoria);
            var categoriaEncontrada = DataManager.GetInstance().ConsultaSQL(sqlQuery, queryValues);
            if (categoriaEncontrada.Rows.Count == 0)
                return null;
            return MappingCategoria(categoriaEncontrada.Rows[0]);
        }


        public int GetLastID()
        {

            var sqlQuery = "SELECT MAX(id_categoria) FROM Categorias";
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
