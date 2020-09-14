using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.Entities;

namespace TPS_PAV.DataAccessLayer
{
    public class CursoDao
    {


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

    }
}
