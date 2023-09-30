using ModeloParcial.Entidades;
using ModeloParcial.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloParcial
{
    public partial class FrmRegistro : Form
    {
        OrdenRetiro ordenRetiro;
        GestorMateriales gestorMateriales;
        GestorOrdenes gestorOrdenes;

        public FrmRegistro()
        {
            InitializeComponent();
            ordenRetiro = new OrdenRetiro();
            gestorMateriales = new GestorMateriales();
            gestorOrdenes = new GestorOrdenes();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            CargarComboMateriales();
        }

        private void CargarComboMateriales()
        {
            cboMateriales.DataSource = gestorMateriales.GetAll();
            cboMateriales.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateriales.DisplayMember = "Nombre";
            cboMateriales.ValueMember = "Codigo";
        }

        private bool ValidarDetalle()
        {
            if (cboMateriales.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un material", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (DataGridViewRow row in dgvDetallesOrdenes.Rows)
            {
                if (row.Cells["ColMaterial"].Value.ToString() == cboMateriales.Text)
                {
                    MessageBox.Show("Este material ya fue agregado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (numCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad no puede ser 0", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidarCantidad(int cantidad, int stock)
        {
            if (cantidad > stock)
            {
                MessageBox.Show($"No hay stock suficiente, hay {stock} unidades", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDetalle())
            {
                Material oMaterial = (Material)cboMateriales.SelectedItem;
                int cantidad = (int)numCantidad.Value;

                if (!ValidarCantidad(cantidad, oMaterial.Stock))
                {
                    return;
                }

                DetalleOrden oDetalleOrden = new DetalleOrden(oMaterial, cantidad);

                ordenRetiro.AgregarDetalle(oDetalleOrden);

                object[] row = new object[]
                {
                    oMaterial.Codigo,
                    oMaterial.Nombre,
                    oMaterial.Stock,
                    cantidad,
                    "Quitar"
                };

                dgvDetallesOrdenes.Rows.Add(row);
            }
        }

        private bool ValidarOrden()
        {
            if (txtResponsable.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un responsable", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dgvDetallesOrdenes.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un material", "Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarOrden())
            {
                ordenRetiro.Fecha = dtpFecha.Value;
                ordenRetiro.Responsable = txtResponsable.Text;

                if (gestorOrdenes.InsertOrden(ordenRetiro))
                {
                    MessageBox.Show("La orden de retiro se ha ingresado con éxito", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se ha podido ingresar la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtResponsable.Text = "";
            cboMateriales.SelectedIndex = -1;
            numCantidad.Value = 0;

            dgvDetallesOrdenes.Rows.Clear();
            ordenRetiro = new OrdenRetiro();
        }

        private void dgvDetallesOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallesOrdenes.CurrentCell.ColumnIndex == 4) 
            {
                ordenRetiro.QuitarDetalle(dgvDetallesOrdenes.CurrentRow.Index);
                dgvDetallesOrdenes.Rows.RemoveAt(dgvDetallesOrdenes.CurrentRow.Index);
            }
        }
    }
}
