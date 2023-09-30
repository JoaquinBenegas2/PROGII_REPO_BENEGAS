namespace Carreras_2023
{
    partial class FrmCarreras2023
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            asignaturasToolStripMenuItem = new ToolStripMenuItem();
            consultarAsignaturasToolStripMenuItem = new ToolStripMenuItem();
            carreraToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, carreraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { asignaturasToolStripMenuItem });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(60, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // asignaturasToolStripMenuItem
            // 
            asignaturasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarAsignaturasToolStripMenuItem });
            asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            asignaturasToolStripMenuItem.Size = new Size(136, 22);
            asignaturasToolStripMenuItem.Text = "Asignaturas";
            // 
            // consultarAsignaturasToolStripMenuItem
            // 
            consultarAsignaturasToolStripMenuItem.Name = "consultarAsignaturasToolStripMenuItem";
            consultarAsignaturasToolStripMenuItem.Size = new Size(190, 22);
            consultarAsignaturasToolStripMenuItem.Text = "Consultar Asignaturas";
            // 
            // carreraToolStripMenuItem
            // 
            carreraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, consultarToolStripMenuItem });
            carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            carreraToolStripMenuItem.Size = new Size(57, 20);
            carreraToolStripMenuItem.Text = "Carrera";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(180, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(180, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // FrmCarreras2023
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmCarreras2023";
            Text = "Carreras 2023";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem asignaturasToolStripMenuItem;
        private ToolStripMenuItem carreraToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem consultarAsignaturasToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
    }
}