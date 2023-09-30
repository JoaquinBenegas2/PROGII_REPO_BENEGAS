using Carreras_2023.Datos;
using Carreras_2023.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras_2023.Presentacion
{
    public partial class FrmConsultarCarrera : Form
    {
        public FrmConsultarCarrera()
        {
            InitializeComponent();
        }

        private void FrmConsultarCarrera_Load(object sender, EventArgs e)
        {
            txtCantAños.Text = "1";
        }

        private bool Validar()
        {
            if (!int.TryParse(txtCantAños.Text, out _))
            {
                MessageBox.Show("El año ingresado debe ser un número", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@cant_años", Convert.ToInt32(txtCantAños.Text))
                };

                DataTable dataTable = new DBHelper().EjecutarSPConsultaConParametros("SP_CONSULTAR_CARRERAS_AÑOS_MAX", listaParametros);

                dgvCarreras.Rows.Clear();
                foreach (DataRow fila in dataTable.Rows)
                {
                    dgvCarreras.Rows.Add(new object[] {
                        fila["id_carrera"].ToString(),
                        fila["Carrera"].ToString(),
                        fila["Cant. Años"].ToString(),
                    });
                }
            }
        }

        private void dgvCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCarreras.CurrentCell.ColumnIndex == 3)
            {
                int idCarrera = Convert.ToInt32(dgvCarreras.CurrentRow.Cells["ColIdCarrera"].Value);
                FrmDetallesCarrera frmDetallesCarrera = new FrmDetallesCarrera(idCarrera);
                frmDetallesCarrera.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de que desea eliminar el vehiculo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int idCarrera = Convert.ToInt32(dgvCarreras.CurrentRow.Cells["ColIdCarrera"].Value);
                List<Parametro> listaParametros = new List<Parametro>
                {
                    new Parametro("@id_carrera", idCarrera)
                };

                int filasAfectadas = new DBHelper().EjecutarSPConParametros("SP_ELIMINAR_CARRERA", listaParametros);
                if (filasAfectadas > 0)
                {
                    dgvCarreras.Rows.RemoveAt(dgvCarreras.CurrentRow.Index);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
