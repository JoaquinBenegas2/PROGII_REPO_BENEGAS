namespace Carreras_2023.Presentacion
{
    partial class FrmConsultarCarrera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCarreras = new DataGridView();
            ColIdCarrera = new DataGridViewTextBoxColumn();
            ColCarrera = new DataGridViewTextBoxColumn();
            ColCantAños = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            gpbFiltros = new GroupBox();
            btnConsultar = new Button();
            txtCantAños = new TextBox();
            lblCantidadAños = new Label();
            button2 = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            gpbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCarreras
            // 
            dgvCarreras.AllowUserToAddRows = false;
            dgvCarreras.AllowUserToDeleteRows = false;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarreras.Columns.AddRange(new DataGridViewColumn[] { ColIdCarrera, ColCarrera, ColCantAños, ColAcciones });
            dgvCarreras.Location = new Point(12, 102);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.ReadOnly = true;
            dgvCarreras.RowTemplate.Height = 26;
            dgvCarreras.Size = new Size(606, 271);
            dgvCarreras.TabIndex = 0;
            dgvCarreras.CellContentClick += dgvCarreras_CellContentClick;
            // 
            // ColIdCarrera
            // 
            ColIdCarrera.HeaderText = "Carrera Nro.";
            ColIdCarrera.Name = "ColIdCarrera";
            ColIdCarrera.ReadOnly = true;
            ColIdCarrera.Visible = false;
            // 
            // ColCarrera
            // 
            ColCarrera.HeaderText = "Carrera";
            ColCarrera.Name = "ColCarrera";
            ColCarrera.ReadOnly = true;
            ColCarrera.Width = 300;
            // 
            // ColCantAños
            // 
            ColCantAños.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCantAños.HeaderText = "Cantidad de Años";
            ColCantAños.Name = "ColCantAños";
            ColCantAños.ReadOnly = true;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "Acciones";
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Resizable = DataGridViewTriState.True;
            ColAcciones.SortMode = DataGridViewColumnSortMode.Automatic;
            ColAcciones.Text = "Ver Detalle";
            ColAcciones.UseColumnTextForButtonValue = true;
            // 
            // gpbFiltros
            // 
            gpbFiltros.Controls.Add(btnConsultar);
            gpbFiltros.Controls.Add(txtCantAños);
            gpbFiltros.Controls.Add(lblCantidadAños);
            gpbFiltros.Location = new Point(12, 11);
            gpbFiltros.Name = "gpbFiltros";
            gpbFiltros.Size = new Size(606, 85);
            gpbFiltros.TabIndex = 1;
            gpbFiltros.TabStop = false;
            gpbFiltros.Text = "Filtros";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(395, 46);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(200, 22);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtCantAños
            // 
            txtCantAños.Location = new Point(160, 16);
            txtCantAños.Name = "txtCantAños";
            txtCantAños.Size = new Size(435, 23);
            txtCantAños.TabIndex = 5;
            // 
            // lblCantidadAños
            // 
            lblCantidadAños.AutoSize = true;
            lblCantidadAños.Location = new Point(6, 19);
            lblCantidadAños.Name = "lblCantidadAños";
            lblCantidadAños.Size = new Size(148, 15);
            lblCantidadAños.TabIndex = 4;
            lblCantidadAños.Text = "Cantidad máxima de años:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 388);
            button2.Name = "button2";
            button2.Size = new Size(96, 22);
            button2.TabIndex = 7;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(114, 388);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 22);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(407, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 22);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmConsultarCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 428);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(button2);
            Controls.Add(gpbFiltros);
            Controls.Add(dgvCarreras);
            Name = "FrmConsultarCarrera";
            Text = "FrmConsultarCarrera";
            Load += FrmConsultarCarrera_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            gpbFiltros.ResumeLayout(false);
            gpbFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCarreras;
        private GroupBox gpbFiltros;
        private Button btnConsultar;
        private TextBox txtCantAños;
        private Label lblCantidadAños;
        private Button button2;
        private Button btnEliminar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn ColIdCarrera;
        private DataGridViewTextBoxColumn ColCarrera;
        private DataGridViewTextBoxColumn ColCantAños;
        private DataGridViewButtonColumn ColAcciones;
    }
}