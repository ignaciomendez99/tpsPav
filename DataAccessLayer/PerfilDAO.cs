using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.Entities;

namespace TPS_PAV.DataAccessLayer
{
    class PerfilDAO
    {
        public IList<Perfil> GetAll()
        {
            List<Perfil> listPerfiles = new List<Perfil>();

            var strSql = "SELECT * from perfiles";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listPerfiles.Add(MappingPerfil(row));
            }

            return listPerfiles;
        }
        private Perfil MappingPerfil(DataRow row)
        {
            Perfil oPerfile = new Perfil
            {
                IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return oPerfile;
        }

    }
}
