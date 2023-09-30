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
    public partial class FrmAgregarCarrera : Form
    {
        DBHelper gestor;
        Carrera carrera;

        public FrmAgregarCarrera()
        {
            InitializeComponent();
            gestor = new DBHelper();
            carrera = new Carrera();
        }

        private void FrmAgregarCarrera_Load(object sender, EventArgs e)
        {
            lblNroCarrera.Text = lblNroCarrera.Text + " " + gestor.ProximaCarrera().ToString();
            CargarMaterias();
            CargarAñoCuatrimestre();
        }

        private void CargarMaterias()
        {
            DataTable tabla = gestor.EjecutarSPConsulta("SP_CONSULTAR_ASIGNATURAS");
            cboMateria.DataSource = tabla;
            cboMateria.ValueMember = tabla.Columns[0].ColumnName;
            cboMateria.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void CargarAñoCuatrimestre()
        {
            List<int> años = new List<int> { 1, 2, 3, 4, 5 };
            List<int> cuatrimestres = new List<int> { 1, 2 };
            cboAñoCursado.DataSource = años;
            cboCuatrimestre.DataSource = cuatrimestres;
        }

        private bool ValidarDetalle()
        {
            if (cboMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una materia", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cboAñoCursado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un año de cursado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cboCuatrimestre.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            foreach (DataGridViewRow row in dgvDetallesCarrera.Rows)
            {
                if (row.Cells["ColAsignatura"].Value.ToString().Equals(cboMateria.Text))
                {
                    MessageBox.Show("Esta materia ya fue agregada", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDetalle())
            {
                DataRowView item = (DataRowView)cboMateria.SelectedItem;

                int id_asignatura = Convert.ToInt32(item.Row.ItemArray[0]);
                string nom_asignatura = item.Row.ItemArray[1].ToString();
                Asignatura oAsignatura = new Asignatura(id_asignatura, nom_asignatura);

                int año_cursado = Convert.ToInt32(cboAñoCursado.SelectedValue);
                int cuatrimestre = Convert.ToInt32(cboCuatrimestre.SelectedValue);

                DetalleCarrera detalleCarrera = new DetalleCarrera(año_cursado, cuatrimestre, oAsignatura);

                carrera.AgregarDetalle(detalleCarrera);

                dgvDetallesCarrera.Rows.Add(new object[] { id_asignatura, nom_asignatura, año_cursado, cuatrimestre, "Quitar" });
            }
        }

        private void dgvDetallesCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallesCarrera.CurrentCell.ColumnIndex == 4)
            {
                carrera.QuitarDetalle(dgvDetallesCarrera.CurrentRow.Index);
                dgvDetallesCarrera.Rows.RemoveAt(dgvDetallesCarrera.CurrentRow.Index);
            }
        }
        private bool ValidarMaestro()
        {
            if (string.IsNullOrEmpty(txtNombreCarrera.Text))
            {
                MessageBox.Show("Debe agregar un nombre de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (dgvDetallesCarrera.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una materia", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarMaestro())
            {
                carrera.NomCarrera = txtNombreCarrera.Text.ToString();

                if (gestor.ConfirmarCarrera(carrera))
                {
                    MessageBox.Show("¡La carrera se registró con éxito!", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}