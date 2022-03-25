
namespace PROG_TEMAS5_RAM
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
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.CBOTEMAS = new System.Windows.Forms.ComboBox();
            this.PanelPadre = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.TextBusqueda = new System.Windows.Forms.TextBox();
            this.PanelBotones.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBotones
            // 
            this.PanelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.PanelBotones.Controls.Add(this.CBOTEMAS);
            this.PanelBotones.ForeColor = System.Drawing.Color.White;
            this.PanelBotones.Location = new System.Drawing.Point(0, 72);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(325, 581);
            this.PanelBotones.TabIndex = 0;
            // 
            // CBOTEMAS
            // 
            this.CBOTEMAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOTEMAS.FormattingEnabled = true;
            this.CBOTEMAS.Items.AddRange(new object[] {
            "Defecto",
            "Morado",
            "Verde",
            "Celeste",
            "Acua",
            "Naranja",
            "Azul"});
            this.CBOTEMAS.Location = new System.Drawing.Point(38, 158);
            this.CBOTEMAS.Name = "CBOTEMAS";
            this.CBOTEMAS.Size = new System.Drawing.Size(242, 28);
            this.CBOTEMAS.TabIndex = 0;
            this.CBOTEMAS.SelectedIndexChanged += new System.EventHandler(this.CBOTEMAS_SelectedIndexChanged);
            // 
            // PanelPadre
            // 
            this.PanelPadre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(17)))), ((int)(((byte)(27)))));
            this.PanelPadre.ForeColor = System.Drawing.Color.White;
            this.PanelPadre.Location = new System.Drawing.Point(324, 69);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(798, 584);
            this.PanelPadre.TabIndex = 1;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.BarraTitulo.Controls.Add(this.TextBusqueda);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1114, 77);
            this.BarraTitulo.TabIndex = 2;
            // 
            // TextBusqueda
            // 
            this.TextBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(73)))), ((int)(((byte)(115)))));
            this.TextBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBusqueda.ForeColor = System.Drawing.Color.White;
            this.TextBusqueda.Location = new System.Drawing.Point(339, 23);
            this.TextBusqueda.Name = "TextBusqueda";
            this.TextBusqueda.Size = new System.Drawing.Size(457, 35);
            this.TextBusqueda.TabIndex = 0;
            this.TextBusqueda.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 657);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.PanelPadre);
            this.Controls.Add(this.PanelBotones);
            this.Name = "Form1";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelBotones.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Panel PanelPadre;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.TextBox TextBusqueda;
        private System.Windows.Forms.ComboBox CBOTEMAS;
    }
}

