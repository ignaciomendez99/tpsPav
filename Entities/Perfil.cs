using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_PAV.Entities
{
    class Perfil
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; } 

        public override string ToString()
        {
            return Nombre;
        }

    }
}
