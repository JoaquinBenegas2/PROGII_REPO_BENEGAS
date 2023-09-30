using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carreras_2023.Presentacion;

namespace Carreras_2023
{
    public partial class FrmCarreras2023 : Form
    {
        public FrmCarreras2023()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCarrera formularioConsultarCarrera = new FrmConsultarCarrera();
            formularioConsultarCarrera.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarCarrera formularioAgregarCarrera = new FrmAgregarCarrera();
            formularioAgregarCarrera.ShowDialog();
        }
    }
}