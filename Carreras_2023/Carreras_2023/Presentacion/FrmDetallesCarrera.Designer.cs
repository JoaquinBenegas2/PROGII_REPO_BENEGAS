namespace Carreras_2023.Presentacion
{
    partial class FrmDetallesCarrera
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
            dgvDetallesCarrera = new DataGridView();
            ColAsignatura = new DataGridViewTextBoxColumn();
            ColAñoCursado = new DataGridViewTextBoxColumn();
            ColCuatrimestre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesCarrera).BeginInit();
            SuspendLayout();
            // 
            // dgvDetallesCarrera
            // 
            dgvDetallesCarrera.AllowUserToAddRows = false;
            dgvDetallesCarrera.AllowUserToDeleteRows = false;
            dgvDetallesCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesCarrera.Columns.AddRange(new DataGridViewColumn[] { ColAsignatura, ColAñoCursado, ColCuatrimestre });
            dgvDetallesCarrera.Location = new Point(12, 12);
            dgvDetallesCarrera.Name = "dgvDetallesCarrera";
            dgvDetallesCarrera.ReadOnly = true;
            dgvDetallesCarrera.RowTemplate.Height = 25;
            dgvDetallesCarrera.Size = new Size(776, 426);
            dgvDetallesCarrera.TabIndex = 0;
            // 
            // ColAsignatura
            // 
            ColAsignatura.HeaderText = "Asignatura";
            ColAsignatura.Name = "ColAsignatura";
            ColAsignatura.ReadOnly = true;
            ColAsignatura.Width = 320;
            // 
            // ColAñoCursado
            // 
            ColAñoCursado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColAñoCursado.HeaderText = "Año de Cursado";
            ColAñoCursado.Name = "ColAñoCursado";
            ColAñoCursado.ReadOnly = true;
            // 
            // ColCuatrimestre
            // 
            ColCuatrimestre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCuatrimestre.HeaderText = "Nro. Cuatrimestre";
            ColCuatrimestre.Name = "ColCuatrimestre";
            ColCuatrimestre.ReadOnly = true;
            // 
            // FrmDetallesCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDetallesCarrera);
            Name = "FrmDetallesCarrera";
            Text = "FrmDetallesCarrera";
            Load += FrmDetallesCarrera_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesCarrera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDetallesCarrera;
        private DataGridViewTextBoxColumn ColAsignatura;
        private DataGridViewTextBoxColumn ColAñoCursado;
        private DataGridViewTextBoxColumn ColCuatrimestre;
    }
}