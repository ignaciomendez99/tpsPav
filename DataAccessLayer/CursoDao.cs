using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPS_PAV.BusinessLayer;
using TPS_PAV.Entities;

namespace TPS_PAV.DataAccessLayer
{
    public class CursoDao
    {
        public IList<Curso> GetCursoBySearch(string searchParam)
        {

            List<Curso> listCurso = new List<Curso>();

            var strSql = "SELECT * from Cursos WHERE (nombre LIKE @search " +
                         "OR descripcion LIKE @search OR id_curso LIKE @search) "+
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

        public IList<Curso> GetCursoBySearchEliminados(string searchParam)
        {

            List<Curso> listCurso = new List<Curso>();

            var strSql = "SELECT * from Cursos WHERE (nombre LIKE @search " +
                         "OR descripcion LIKE @search OR id_curso LIKE @search); ";
                         

            Dictionary<string, object> dictSql = new Dictionary<string, object>();

            dictSql.Add("@search", "%" + searchParam + "%");

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, dictSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listCurso.Add(MappingCurso(row));
            }

            return listCurso;
        }


        public bool CheckCursoEliminado(Curso curso)
        {

            var strSql = "Select borrado from cursos where id_curso = @idcurso";
            Dictionary<string, object> sqlValues = new Dictionary<string, object>()
            {
                {"@idcurso", curso.IdCurso}
            };

            var res = Convert.ToInt32(DataManager.GetInstance().ConsultaSQLScalar(strSql,sqlValues));
            if (res == 1) return true;
            else return false;
            
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

        public IList<Curso> GetAllYEliminados()
        {
            List<Curso> listCurso = new List<Curso>();

            var strSql = "SELECT * from Cursos";

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

        public bool DeleteCursos(List<Curso> cursosList)
        {
            DataManager dm = DataManager.GetInstance();

            bool success = false;
            try
            {
                dm.BeginTransaction();
                foreach(Curso curso in cursosList)
                {
                    var sqlQuery = "UPDATE Cursos SET borrado = 1 WHERE id_curso = @idCurso";
                    Dictionary<string, object> queryValues = new Dictionary<string, object>();

                    queryValues.Add("@idCurso", curso.IdCurso);

                    dm.EjecutarSQL(sqlQuery, queryValues);
                }

                dm.Commit();
                success = true;


            }

            catch (Exception e)
            {
                dm.Rollback();

            }

            return success;

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
        public bool TransactObjetivoCurso(List<Objetivo> objListToAdd, List<Objetivo> objListToRemove , Curso curso)
        {

            DataManager dm = DataManager.GetInstance();

            Boolean succes = false;
            try
            {
                dm.BeginTransaction();

                foreach (Objetivo objt in objListToRemove)
                {

                    var sqlQueryRem = "DELETE FROM ObjetivosCursos WHERE id_objetivo = @idobjetivo AND id_curso = @idcurso";

                    Dictionary<string, object> queryValuesRemove = new Dictionary<string, object>();
                    queryValuesRemove.Add("@idobjetivo", objt.IdObjetivo);
                    queryValuesRemove.Add("@idcurso", curso.IdCurso);

                    dm.EjecutarSQL(sqlQueryRem, queryValuesRemove);
                }

                List<int> listObjId = new List<int>();

                var sqlQuerySearch = "SELECT id_objetivo FROM ObjetivosCursos WHERE id_curso = @idcurso";
                Dictionary<string, object> queryValues = new Dictionary<string, object>();
                queryValues.Add("@idcurso", curso.IdCurso);


                var resultadoConsulta = dm.ConsultaSQL(sqlQuerySearch, queryValues);

                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listObjId.Add(Convert.ToInt32(row["id_objetivo"].ToString()));
                }


                foreach (Objetivo objt in objListToAdd)
                {

                    if (listObjId.Contains(objt.IdObjetivo))
                        continue;
                    
                    var sqlQueryAdd = "INSERT INTO ObjetivosCursos (id_objetivo, id_curso, puntos, borrado) VALUES (@idobjetivo, @idcurso, 0, 0)";

                    Dictionary<string, object> queryValuesAdd = new Dictionary<string, object>();
                    queryValuesAdd.Add("@idobjetivo", objt.IdObjetivo);
                    queryValuesAdd.Add("@idcurso", curso.IdCurso);

                    dm.EjecutarSQL(sqlQueryAdd, queryValuesAdd);
                
                }


                dm.Commit();
                succes = true;
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                dm.Rollback();
            }

            return succes;

        }

        public Curso getCursoById(int idCurso)
        {

            var sqlQuery = "SELECT * FROM Cursos WHERE id_curso = @idcurso ";
            Dictionary<string, object> queryValues = new Dictionary<string, object>();
            queryValues.Add("@idcurso", idCurso);
            var cursoEncontrado = DataManager.GetInstance().ConsultaSQL(sqlQuery, queryValues);
            if (cursoEncontrado.Rows.Count == 0)
                return null;
            return MappingCurso(cursoEncontrado.Rows[0]);
        }


    }
}
