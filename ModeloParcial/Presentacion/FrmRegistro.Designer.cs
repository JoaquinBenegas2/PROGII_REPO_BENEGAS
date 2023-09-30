namespace ModeloParcial
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.cboMateriales = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetallesOrdenes = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(55, 15);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(106, 13);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(443, 21);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(11, 41);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(91, 17);
            this.lblResponsable.TabIndex = 2;
            this.lblResponsable.Text = "Responsable";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(106, 38);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(442, 23);
            this.txtResponsable.TabIndex = 3;
            // 
            // cboMateriales
            // 
            this.cboMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMateriales.FormattingEnabled = true;
            this.cboMateriales.Location = new System.Drawing.Point(106, 73);
            this.cboMateriales.Margin = new System.Windows.Forms.Padding(2);
            this.cboMateriales.Name = "cboMateriales";
            this.cboMateriales.Size = new System.Drawing.Size(297, 25);
            this.cboMateriales.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(414, 103);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetallesOrdenes
            // 
            this.dgvDetallesOrdenes.AllowUserToAddRows = false;
            this.dgvDetallesOrdenes.AllowUserToDeleteRows = false;
            this.dgvDetallesOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColMaterial,
            this.ColStock,
            this.ColCantidad,
            this.ColAcciones});
            this.dgvDetallesOrdenes.Location = new System.Drawing.Point(14, 140);
            this.dgvDetallesOrdenes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetallesOrdenes.Name = "dgvDetallesOrdenes";
            this.dgvDetallesOrdenes.ReadOnly = true;
            this.dgvDetallesOrdenes.RowHeadersWidth = 51;
            this.dgvDetallesOrdenes.RowTemplate.Height = 24;
            this.dgvDetallesOrdenes.Size = new System.Drawing.Size(535, 122);
            this.dgvDetallesOrdenes.TabIndex = 7;
            this.dgvDetallesOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesOrdenes_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColMaterial
            // 
            this.ColMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMaterial.HeaderText = "MATERIAL";
            this.ColMaterial.MinimumWidth = 6;
            this.ColMaterial.Name = "ColMaterial";
            this.ColMaterial.ReadOnly = true;
            // 
            // ColStock
            // 
            this.ColStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColStock.HeaderText = "STOCK";
            this.ColStock.MinimumWidth = 6;
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCantidad.HeaderText = "CANTIDAD";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAcciones.HeaderText = "ACCIONES";
            this.ColAcciones.MinimumWidth = 6;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(276, 270);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(134, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(414, 270);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(414, 78);
            this.numCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(134, 20);
            this.numCantidad.TabIndex = 5;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 321);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetallesOrdenes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboMateriales);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistro";
            this.Text = "Registrar Orden de Retiro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.ComboBox cboMateriales;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetallesOrdenes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}

