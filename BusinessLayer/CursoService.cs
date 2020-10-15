using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.DataAccessLayer;
using TPS_PAV.Entities;

namespace TPS_PAV.BusinessLayer
{
    public class CursoService
    {
        private CursoDao oCursoDao;

        public CursoService()
        {
            oCursoDao = new CursoDao();
        }
        public void AgregarCurso(Curso curso)
        {
            oCursoDao.InsertCurso(curso);
        }

        public IList<Curso> ObtenerCursos()
        {
            return oCursoDao.GetAll();
        }

        public IList<Curso> ObtenerCursosYEliminados()
        {
            return oCursoDao.GetAllYEliminados();
        }

        public IList<Curso> ObtenerCursoBuscado(string busqueda)
        {
            return oCursoDao.GetCursoBySearch(busqueda);
        }

        public IList<Curso> ObtenerCursoBuscadoEliminados(string busqueda)
        {
            return oCursoDao.GetCursoBySearchEliminados(busqueda);
        }

        public void BorrarCurso(Curso curso)
        {
            oCursoDao.DeleteCurso(curso);
        }

        public void ModificarCurso(Curso curso)
        {
            oCursoDao.ModifyCurso(curso);
        }

        public bool CheckCursoEliminado(Curso curso)
        {
            return oCursoDao.CheckCursoEliminado(curso);
        }


    }
}
