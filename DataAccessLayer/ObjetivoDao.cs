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

    }
}