using Carreras_2023.Datos;
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
    public partial class FrmDetallesCarrera : Form
    {
        int idCarrera;
        public FrmDetallesCarrera(int idCarrera)
        {
            InitializeComponent();
            this.idCarrera = idCarrera;
        }

        private void FrmDetallesCarrera_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            List<Parametro> listaParametros = new List<Parametro>
            {
                new Parametro("@id_carrera", idCarrera)
            };

            DataTable dataTable = new DBHelper().EjecutarSPConsultaConParametros("SP_CONSULTAR_DETALLES_CARRERA", listaParametros);

            dgvDetallesCarrera.Rows.Clear();
            foreach (DataRow fila in dataTable.Rows)
            {
                dgvDetallesCarrera.Rows.Add(new object[] {
                    fila["nom_asignatura"].ToString(),
                    fila["año_cursado"].ToString(),
                    fila["cuatrimestre"].ToString(),
                });
            }
        }
    }
}
