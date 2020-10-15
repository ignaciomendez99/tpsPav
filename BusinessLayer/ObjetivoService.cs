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
        public bool NuevoObjetivo(string nombre, string descripcion)
        {
            return objetivoDao.NuevoObjetivo(nombre, descripcion);
        }

        public IList<Objetivo> GetObjetivoBySearch(string searchParam)
        {
            return objetivoDao.GetObjetivoBySearch(searchParam);
        }

        public IList<Objetivo> GetAllYEliminados()
        {
            return objetivoDao.GetAllYEliminados();
        }

        public bool DeleteObjetivo(Objetivo objetivo)
        {
            return objetivoDao.DeleteObjetivo(objetivo);
        }

        public bool DeleteObjetivos(List<Objetivo> objList)
        {
            return objetivoDao.DeleteObjetivos(objList);
        }

        public IList<Objetivo> GetObjetivoBySearchEliminados(string searchParam)
        {
            return objetivoDao.GetObjetivoBySearchEliminados(searchParam);
        }

        public bool CheckObjetivoEliminado(Objetivo ob)
        {
            return objetivoDao.CheckObjetivoEliminado(ob);
        }
    }
}