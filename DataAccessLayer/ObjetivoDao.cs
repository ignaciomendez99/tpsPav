using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.DataAccessLayer;
using TPS_PAV.Entities;

namespace TPS_PAV.BusinessLayer
{
    class ObjetivoDao
    {

        public IList<Objetivo> GetAll()
        {
            List<Objetivo> lista = new List<Objetivo>();

            var strSql = "SELECT * FROM Objetivos WHERE borrado = 0;";

            var res = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in res.Rows)
            {
                lista.Add(MapperObjetivo(row));

            }

            return lista;

        }

        public IList<Objetivo> GetAllOwnedByCurso(Curso curso)
        {
            List<Objetivo> lista = new List<Objetivo>();

            var strSql = "SELECT * FROM Objetivos o WHERE o.borrado = 0 AND id_objetivo IN( SELECT oc.id_objetivo FROM ObjetivosCursos oc WHERE oc.id_curso = @idcurso)";



            Dictionary<string, object> queryValues = new Dictionary<string, object>();
            queryValues.Add("@idcurso", curso.IdCurso);

            var res = DataManager.GetInstance().ConsultaSQL(strSql, queryValues);


            foreach (DataRow row in res.Rows)
            {
                lista.Add(MapperObjetivo(row));

            }

            return lista;

        }




        


        public IList<Objetivo> GetAllExceptOwnedByCurso(Curso curso)
        {
            List<Objetivo> lista = new List<Objetivo>();

            var strSql = "SELECT * FROM Objetivos o WHERE o.borrado = 0 AND id_objetivo NOT IN( SELECT oc.id_objetivo FROM ObjetivosCursos oc WHERE oc.id_curso = @idcurso)";



            Dictionary<string, object> queryValues = new Dictionary<string, object>();
            queryValues.Add("@idcurso", curso.IdCurso);

            var res = DataManager.GetInstance().ConsultaSQL(strSql, queryValues);


            foreach (DataRow row in res.Rows)
            {
                lista.Add(MapperObjetivo(row));

            }

            return lista;

        }

        public bool DeleteObjetivos(List<Objetivo> objList)
        {
            DataManager dm = DataManager.GetInstance();

            bool succes = false;
            try
            {
                dm.BeginTransaction();


                foreach (Objetivo objt in objList)
                {
                    
                    var sqlQuery = "UPDATE Objetivos SET borrado = 1 WHERE id_objetivo = @idobjetivo";

                    Dictionary<string, object> queryValuesAdd = new Dictionary<string, object>();
                    queryValuesAdd.Add("@idobjetivo", objt.IdObjetivo);

                    dm.EjecutarSQL(sqlQuery, queryValuesAdd);
                
                }


                dm.Commit();
                succes = true;
            } 
            catch(Exception ex)
            {
                dm.Rollback();
            }

            return succes;

        }

        public Objetivo MapperObjetivo(DataRow row)
        {

            Objetivo objetivo = new Objetivo
            {
                IdObjetivo = Convert.ToInt32(row["id_objetivo"].ToString()),
                NombreCorto = row["nombre_corto"].ToString(),
                NombreLargo = row["nombre_largo"].ToString()

            };

            return objetivo;


        }

        public bool NuevoObjetivo(string nombre, string descripcion)
        {
            var strSql = "insert into Objetivos(id_objetivo, nombre_largo, nombre_corto, borrado) values (@id,@nombreLargo,@nombreCorto,0);";

            Dictionary<string, object> sqlValues = new Dictionary<string, object>
            {
                {"@id",getLastID() + 1},
                {"@nombreLargo",  descripcion},
                {"@nombreCorto", nombre }
            };

            try
            {
                DataManager.GetInstance().EjecutarSQL(strSql, sqlValues);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        private int getLastID()
        {
            var strSql = "SELECT MAX(id_objetivo) FROM Objetivos";

            var res = DataManager.GetInstance().ConsultaSQLScalar(strSql);

            if (res is System.DBNull)
            // La consulta SQL Scalar devuelve DBNull en caso de Null.
            {
                return 0;
            }

            return (int) res;

            
        }

        public IList<Objetivo> GetObjetivoBySearch(string searchParam)
        {

            List<Objetivo> listObjetivo = new List<Objetivo>();

            var strSql = "SELECT * from Objetivos WHERE (nombre_corto LIKE @search " +
                         "OR nombre_largo LIKE @search) " +
                         "AND borrado = 0";

            Dictionary<string, object> dictSql = new Dictionary<string, object>();

            dictSql.Add("@search", "%" + searchParam + "%");

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, dictSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listObjetivo.Add(MapperObjetivo(row));
            }

            return listObjetivo;
        }

        public IList<Objetivo> GetAllYEliminados()
        {
            List<Objetivo> lista = new List<Objetivo>();

            var strSql = "SELECT * FROM Objetivos;";

            var res = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in res.Rows)
            {
                lista.Add(MapperObjetivo(row));

            }
            return lista;

        }


        public bool DeleteObjetivo(Objetivo objetivo)
        {

            var sqlQuery = "UPDATE Objetivos SET borrado = 1 WHERE id_objetivo = @idObjetivo";

            Dictionary<string, object> queryValues = new Dictionary<string, object>();

            queryValues.Add("@idObjetivo", objetivo.IdObjetivo);
            try
            {
                DataManager.GetInstance().EjecutarSQL(sqlQuery, queryValues);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }

        public IList<Objetivo> GetObjetivoBySearchEliminados(string searchParam)
        {

            List<Objetivo> listObjetivo = new List<Objetivo>();

            var strSql = "SELECT * from Objetivos WHERE (nombre_corto LIKE @search " +
                         "OR nombre_largo LIKE @search); ";
                         

            Dictionary<string, object> dictSql = new Dictionary<string, object>();

            dictSql.Add("@search", "%" + searchParam + "%");

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql, dictSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listObjetivo.Add(MapperObjetivo(row));
            }

            return listObjetivo;
        }

        public bool CheckObjetivoEliminado(Objetivo ob)
        {
            var strSql = "Select borrado from Objetivos where id_objetivo = @idObjetivo";
            Dictionary<string, object> sqlValues = new Dictionary<string, object>()
            {
                {"@idObjetivo", ob.IdObjetivo}
            };

            var res = Convert.ToInt32(DataManager.GetInstance().ConsultaSQLScalar(strSql, sqlValues));
            if (res == 1) return true;
            else return false;
        }




    }
}