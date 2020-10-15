using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.Entities;

namespace TPS_PAV.BusinessLayer
{
    public class ObjetivoService
    {

        private readonly ObjetivoDao objetivoDao;

        public ObjetivoService()
        {
            objetivoDao = new ObjetivoDao();
        }

        public IList<Objetivo> ObtenerTodos()
        {
            return objetivoDao.GetAll();
        }

        public void NuevoObjetivo()
        {
            var strSql = "insert into Objetivos(id_objetivo, nombre_largo, nombre_corto, borrado) values (@id,@nombreLargo,@nombreCorto,0);";

            Dictionary<string, object> sqlValues = new Dictionary<string, object>
            {
                {"@id",  }
            }

        }



    }
}