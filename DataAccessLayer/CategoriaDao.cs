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

            var strSql = "SELECT * from Categorias";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listCategorias.Add(MappingCategoria(row));
            }

            return listCategorias;
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

        
    }
}
