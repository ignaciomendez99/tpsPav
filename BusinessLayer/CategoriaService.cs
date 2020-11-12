using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using TPS_PAV.DataAccessLayer;
using TPS_PAV.Entities;

namespace TPS_PAV.BusinessLayer
{
    class CategoriaService
    {
        private CategoriaDao oCategoriaDao;
        public CategoriaService()
        {
            oCategoriaDao = new CategoriaDao();
        }
        public IList<Categoria> ObtenerTodos()
        {
            return oCategoriaDao.GetAll();
        }

        public IList<Categoria> GetAllYEliminados()
        {
            return oCategoriaDao.GetAllYEliminados();
        }

        public bool DeleteCatagorias(IList<Categoria> catList)
        {
            return oCategoriaDao.DeleteCategorias(catList);
        }

        public Categoria ObtenerCategoriaById(int idCategoria)
        {

            return oCategoriaDao.getCategoriaById(idCategoria);

        }

        public void ModificarCategoria(Categoria cat)
        {
            oCategoriaDao.ModificarCategoria(cat);
        }

        public IList<Categoria> GetCategoriaBySearchEliminados(string searchParam)
        {
            return oCategoriaDao.GetCategoriaBySearchEliminados(searchParam);
        }

        public IList<Categoria> GetCategoriaBySearch(string searchParam)
        {
            return oCategoriaDao.GetCategoriaBySearch(searchParam);
        }

        public bool CheckCategoriaEliminado(Categoria cat)
        {
            return oCategoriaDao.CheckCategoriaEliminado(cat);
        }

        public int GetLastID()
        {
            return oCategoriaDao.GetLastID();
        }

        public void AgregarCategoria(Categoria cat)
        {
            oCategoriaDao.InsertCategoria(cat);
        }

    }

}
