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

        public IList<Objetivo> ObtenerTodosMenosEnCurso(Curso curso)
        {
            return objetivoDao.GetAllExceptOwnedByCurso(curso);
        }

        public IList<Objetivo> ObtenerTodosEnCurso(Curso curso)
        {
            return objetivoDao.GetAllOwnedByCurso(curso);
        }

    }
}