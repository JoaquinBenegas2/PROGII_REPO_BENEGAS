namespace Carreras_2023.Presentacion
{
    partial class FrmAgregarCarrera
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
            lblNroCarrera = new Label();
            cboMateria = new ComboBox();
            lblMateria = new Label();
            lblNombreCarrera = new Label();
            lblAgregarMateria = new Label();
            lblAñoCursado = new Label();
            lblCuatrimestre = new Label();
            dgvDetallesCarrera = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ColAsignatura = new DataGridViewTextBoxColumn();
            ColAñoCursado = new DataGridViewTextBoxColumn();
            ColCuatrimestre = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            cboAñoCursado = new ComboBox();
            cboCuatrimestre = new ComboBox();
            btnAgregar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtNombreCarrera = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesCarrera).BeginInit();
            SuspendLayout();
            // 
            // lblNroCarrera
            // 
            lblNroCarrera.AutoSize = true;
            lblNroCarrera.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroCarrera.Location = new Point(12, 13);
            lblNroCarrera.Name = "lblNroCarrera";
            lblNroCarrera.Size = new Size(92, 21);
            lblNroCarrera.TabIndex = 0;
            lblNroCarrera.Text = "Carrera N°:";
            // 
            // cboMateria
            // 
            cboMateria.FormattingEnabled = true;
            cboMateria.Location = new Point(126, 113);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(514, 23);
            cboMateria.TabIndex = 1;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMateria.Location = new Point(70, 117);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(53, 15);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Materia:";
            // 
            // lblNombreCarrera
            // 
            lblNombreCarrera.AutoSize = true;
            lblNombreCarrera.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCarrera.Location = new Point(66, 42);
            lblNombreCarrera.Name = "lblNombreCarrera";
            lblNombreCarrera.Size = new Size(56, 15);
            lblNombreCarrera.TabIndex = 4;
            lblNombreCarrera.Text = "Nombre:";
            // 
            // lblAgregarMateria
            // 
            lblAgregarMateria.AutoSize = true;
            lblAgregarMateria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarMateria.Location = new Point(12, 89);
            lblAgregarMateria.Name = "lblAgregarMateria";
            lblAgregarMateria.Size = new Size(138, 21);
            lblAgregarMateria.TabIndex = 5;
            lblAgregarMateria.Text = "Agregar Materia:";
            // 
            // lblAñoCursado
            // 
            lblAñoCursado.AutoSize = true;
            lblAñoCursado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAñoCursado.Location = new Point(27, 149);
            lblAñoCursado.Name = "lblAñoCursado";
            lblAñoCursado.Size = new Size(95, 15);
            lblAñoCursado.TabIndex = 7;
            lblAñoCursado.Text = "Año de cursado:";
            // 
            // lblCuatrimestre
            // 
            lblCuatrimestre.AutoSize = true;
            lblCuatrimestre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCuatrimestre.Location = new Point(348, 149);
            lblCuatrimestre.Name = "lblCuatrimestre";
            lblCuatrimestre.Size = new Size(83, 15);
            lblCuatrimestre.TabIndex = 9;
            lblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // dgvDetallesCarrera
            // 
            dgvDetallesCarrera.AllowUserToAddRows = false;
            dgvDetallesCarrera.AllowUserToDeleteRows = false;
            dgvDetallesCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesCarrera.Columns.AddRange(new DataGridViewColumn[] { Id, ColAsignatura, ColAñoCursado, ColCuatrimestre, ColAccion });
            dgvDetallesCarrera.Location = new Point(11, 227);
            dgvDetallesCarrera.Name = "dgvDetallesCarrera";
            dgvDetallesCarrera.ReadOnly = true;
            dgvDetallesCarrera.RowTemplate.Height = 25;
            dgvDetallesCarrera.Size = new Size(628, 150);
            dgvDetallesCarrera.TabIndex = 11;
            dgvDetallesCarrera.CellContentClick += dgvDetallesCarrera_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // ColAsignatura
            // 
            ColAsignatura.HeaderText = "Asignatura";
            ColAsignatura.Name = "ColAsignatura";
            ColAsignatura.ReadOnly = true;
            ColAsignatura.Width = 200;
            // 
            // ColAñoCursado
            // 
            ColAñoCursado.HeaderText = "Año de Cursado";
            ColAñoCursado.Name = "ColAñoCursado";
            ColAñoCursado.ReadOnly = true;
            ColAñoCursado.Width = 175;
            // 
            // ColCuatrimestre
            // 
            ColCuatrimestre.HeaderText = "Cuatrimestre";
            ColCuatrimestre.Name = "ColCuatrimestre";
            ColCuatrimestre.ReadOnly = true;
            ColCuatrimestre.Width = 120;
            // 
            // ColAccion
            // 
            ColAccion.HeaderText = "Accion";
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            ColAccion.Width = 90;
            // 
            // cboAñoCursado
            // 
            cboAñoCursado.FormattingEnabled = true;
            cboAñoCursado.Location = new Point(126, 145);
            cboAñoCursado.Name = "cboAñoCursado";
            cboAñoCursado.Size = new Size(208, 23);
            cboAñoCursado.TabIndex = 12;
            // 
            // cboCuatrimestre
            // 
            cboCuatrimestre.FormattingEnabled = true;
            cboCuatrimestre.Location = new Point(432, 145);
            cboCuatrimestre.Name = "cboCuatrimestre";
            cboCuatrimestre.Size = new Size(208, 23);
            cboCuatrimestre.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(432, 182);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(208, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(432, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(207, 23);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(218, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(208, 23);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.Location = new Point(126, 38);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.Size = new Size(513, 23);
            txtNombreCarrera.TabIndex = 17;
            // 
            // FrmAgregarCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 450);
            Controls.Add(txtNombreCarrera);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(cboCuatrimestre);
            Controls.Add(cboAñoCursado);
            Controls.Add(dgvDetallesCarrera);
            Controls.Add(lblCuatrimestre);
            Controls.Add(lblAñoCursado);
            Controls.Add(lblAgregarMateria);
            Controls.Add(lblNombreCarrera);
            Controls.Add(lblMateria);
            Controls.Add(cboMateria);
            Controls.Add(lblNroCarrera);
            Name = "FrmAgregarCarrera";
            Text = "FrmAgregarCarrera";
            Load += FrmAgregarCarrera_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesCarrera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNroCarrera;
        private ComboBox cboMateria;
        private Label lblMateria;
        private Label lblNombreCarrera;
        private Label lblAgregarMateria;
        private Label lblAñoCursado;
        private Label lblCuatrimestre;
        private DataGridView dgvDetallesCarrera;
        private ComboBox cboAñoCursado;
        private ComboBox cboCuatrimestre;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ColAsignatura;
        private DataGridViewTextBoxColumn ColAñoCursado;
        private DataGridViewTextBoxColumn ColCuatrimestre;
        private DataGridViewButtonColumn ColAccion;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtNombreCarrera;
    }
}