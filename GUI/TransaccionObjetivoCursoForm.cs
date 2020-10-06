using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPS_PAV.BusinessLayer;

namespace TPS_PAV.GUI
{
    public partial class TransaccionObjetivoCursoForm : Form
    {
        private readonly ObjetivoService objetivoService;

        public TransaccionObjetivoCursoForm()
        {
            InitializeComponent();
            objetivoService = new ObjetivoService();
        }

        public void InicarDataGridView()
        {
            dgvObjetivosCurso.DataSource = objetivoService.ObtenerTodos();

        }


    }
}
