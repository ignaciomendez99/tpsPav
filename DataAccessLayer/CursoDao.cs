using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.BusinessLayer;
using TPS_PAV.Entities;

namespace TPS_PAV.DataAccessLayer
{
    public class CursoDao
    {
        // VER IMPLEMENTAR POR FECHA
        public IList<Curso> GetCursoBySearch(string searchParam)
        {

            List<Curso> listCurso = new List<Curso>();

            var strSql = "SELECT * from Cursos WHERE (nombre LIKE @search " +
                         "OR descripcion LIKE @search ) "+
                         "AND borrado = 0";

            Dictionary<string, object> dictSql = new Dictionary<string, object>();

            dictSql.Add("@search", "%" + searchParam + "%");

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, dictSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listCurso.Add(MappingCurso(row));
            }

            return listCurso;
        }

        public IList<Curso> GetAll()
        {
            List<Curso> listCurso = new List<Curso>();

            var strSql = "SELECT * from Cursos WHERE borrado = 0";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listCurso.Add(MappingCurso(row));
            }

            return listCurso;
        }

        private Curso MappingCurso(DataRow row)
        {
            CategoriaService catService = new CategoriaService();

            Curso oCurso = new Curso
            {
                IdCurso = Convert.ToInt32(row["id_curso"].ToString()),
                Categoria = catService.ObtenerCategoriaById(Convert.ToInt32(row["id_categoria"])),
                Descripcion = row["descripcion"].ToString(),
                FechaVigencia = DateTime.Parse(row["fecha_vigencia"].ToString()),
                NombreCurso = row["nombre"].ToString()

            };

            return oCurso;
            
        }

        public void DeleteCurso(Curso curso)
        {

            var sqlQuery = "UPDATE Cursos SET borrado = 1 WHERE id_curso = @idcurso";

            Dictionary<string, object> queryValues = new Dictionary<string, object>();

            queryValues.Add("@idcurso", curso.IdCurso);

            DataManager.GetInstance().EjecutarSQL(sqlQuery, queryValues);
        }

        public void InsertCurso(Curso curso)
        {

            var sqlQuery = "INSERT INTO Cursos(id_curso, nombre, descripcion, fecha_vigencia, id_categoria, borrado) VALUES (@idcurso, @nom, @desc, @fechaVigente,@idCategoria,@borrado)";
            Dictionary <string, object> queryValues = new Dictionary<string, object>();

            queryValues.Add("@idcurso", GetLastIdCurso() + 1);
            queryValues.Add("@nom", curso.NombreCurso);
            queryValues.Add("@desc", curso.Descripcion);
            queryValues.Add("@fechaVigente", curso.FechaVigencia);
            queryValues.Add("@idCategoria", curso.Categoria.IdCategoria);
            queryValues.Add("@borrado", 0);

            DataManager.GetInstance().EjecutarSQL(sqlQuery, queryValues);

        }

        private int GetLastIdCurso()
        {

            var sqlQuery = "SELECT MAX(id_curso) FROM Cursos";
            var lastID = DataManager.GetInstance().ConsultaSQLScalar(sqlQuery);
            if (lastID is System.DBNull) 
            // La consulta SQL Scalar devuelve DBNull en caso de Null.
            {
                return 0;
            }
            return (int) lastID;
            
        }

        public void ModifyCurso(Curso curso)
        {

            var sqlQuery = "UPDATE Cursos SET nombre = @nombre, descripcion = @descripcion, fecha_vigencia = @fechaVigencia, id_categoria = @idcategoria WHERE id_curso = @idcurso";

            Dictionary<string, object> queryValues = new Dictionary<string, object>();

            queryValues.Add("@idcurso", curso.IdCurso);
            queryValues.Add("@nombre", curso.NombreCurso);
            queryValues.Add("@descripcion", curso.Descripcion);
            queryValues.Add("@fechaVigencia", curso.FechaVigencia);
            queryValues.Add("@idcategoria", curso.Categoria.IdCategoria);

            DataManager.GetInstance().EjecutarSQL(sqlQuery,queryValues);
                       
        }

    }
}
