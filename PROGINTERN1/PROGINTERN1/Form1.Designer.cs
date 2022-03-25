
namespace PROGINTERN1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIdiomas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEspañol = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNALUMNOS = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuOpciones,
            this.menuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlumnos,
            this.menuSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(111, 36);
            this.menuArchivo.Text = "&Archivo";
            // 
            // menuAlumnos
            // 
            this.menuAlumnos.Name = "menuAlumnos";
            this.menuAlumnos.Size = new System.Drawing.Size(270, 40);
            this.menuAlumnos.Text = "Alumnos";
            this.menuAlumnos.Click += new System.EventHandler(this.menuAlumnos_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(270, 40);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // menuOpciones
            // 
            this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIdiomas});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(131, 36);
            this.menuOpciones.Text = "&Opciones";
            // 
            // menuIdiomas
            // 
            this.menuIdiomas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEspañol,
            this.menuIngles});
            this.menuIdiomas.Name = "menuIdiomas";
            this.menuIdiomas.Size = new System.Drawing.Size(270, 40);
            this.menuIdiomas.Text = "Idioma";
            // 
            // menuEspañol
            // 
            this.menuEspañol.Name = "menuEspañol";
            this.menuEspañol.Size = new System.Drawing.Size(270, 40);
            this.menuEspañol.Text = "Español";
            this.menuEspañol.Click += new System.EventHandler(this.menuEspañol_Click);
            // 
            // menuIngles
            // 
            this.menuIngles.Name = "menuIngles";
            this.menuIngles.Size = new System.Drawing.Size(270, 40);
            this.menuIngles.Text = "Inglés";
            this.menuIngles.Click += new System.EventHandler(this.menuIngles_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcercaDe});
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(98, 36);
            this.menuAyuda.Text = "Ay&uda";
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(270, 40);
            this.menuAcercaDe.Text = "Acerca de";
            // 
            // BTNALUMNOS
            // 
            this.BTNALUMNOS.Location = new System.Drawing.Point(273, 285);
            this.BTNALUMNOS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNALUMNOS.Name = "BTNALUMNOS";
            this.BTNALUMNOS.Size = new System.Drawing.Size(287, 61);
            this.BTNALUMNOS.TabIndex = 1;
            this.BTNALUMNOS.Text = "&Alumnos";
            this.BTNALUMNOS.UseVisualStyleBackColor = true;
            this.BTNALUMNOS.Click += new System.EventHandler(this.menuAlumnos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 480);
            this.Controls.Add(this.BTNALUMNOS);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem menuIdiomas;
        private System.Windows.Forms.ToolStripMenuItem menuEspañol;
        private System.Windows.Forms.ToolStripMenuItem menuIngles;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem menuAlumnos;
        private System.Windows.Forms.Button BTNALUMNOS;
    }
}

