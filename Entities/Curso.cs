using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_PAV.Entities
{
    public class Curso
    {

        public int IdCurso { get; set; }

        public string NombreCurso { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaVigencia { get; set; }

        public Categoria Categoria { get; set; }

        
    }
}
