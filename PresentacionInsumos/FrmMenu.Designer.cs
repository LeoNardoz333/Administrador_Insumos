namespace PresentacionInsumos
{
    partial class FrmMenu
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.optInsumos = new System.Windows.Forms.ToolStripButton();
            this.optProductos = new System.Windows.Forms.ToolStripButton();
            this.optVentas = new System.Windows.Forms.ToolStripButton();
            this.optResultados = new System.Windows.Forms.ToolStripButton();
            this.optSalir = new System.Windows.Forms.ToolStripButton();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optInsumos,
            this.optProductos,
            this.optVentas,
            this.optResultados,
            this.optSalir});
            this.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(85, 323);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // optInsumos
            // 
            this.optInsumos.Image = global::PresentacionInsumos.Properties.Resources.almacen;
            this.optInsumos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optInsumos.Name = "optInsumos";
            this.optInsumos.Size = new System.Drawing.Size(82, 20);
            this.optInsumos.Text = "Insumos";
            this.optInsumos.Click += new System.EventHandler(this.optInsumos_Click);
            // 
            // optProductos
            // 
            this.optProductos.Image = global::PresentacionInsumos.Properties.Resources.caja;
            this.optProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optProductos.Name = "optProductos";
            this.optProductos.Size = new System.Drawing.Size(82, 20);
            this.optProductos.Text = "Productos";
            this.optProductos.Click += new System.EventHandler(this.optProductos_Click);
            // 
            // optVentas
            // 
            this.optVentas.Image = global::PresentacionInsumos.Properties.Resources.ventas;
            this.optVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optVentas.Name = "optVentas";
            this.optVentas.Size = new System.Drawing.Size(82, 20);
            this.optVentas.Text = "Ventas";
            this.optVentas.Click += new System.EventHandler(this.optVentas_Click);
            // 
            // optResultados
            // 
            this.optResultados.Image = global::PresentacionInsumos.Properties.Resources._4295914;
            this.optResultados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optResultados.Name = "optResultados";
            this.optResultados.Size = new System.Drawing.Size(82, 20);
            this.optResultados.Text = "Resultados";
            this.optResultados.Click += new System.EventHandler(this.optResultados_Click);
            // 
            // optSalir
            // 
            this.optSalir.Image = global::PresentacionInsumos.Properties.Resources.eliminar;
            this.optSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optSalir.Name = "optSalir";
            this.optSalir.Size = new System.Drawing.Size(82, 20);
            this.optSalir.Text = "Salir";
            this.optSalir.Click += new System.EventHandler(this.optSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 323);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.Text = "Control de insumos y ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton optInsumos;
        private System.Windows.Forms.ToolStripButton optProductos;
        private System.Windows.Forms.ToolStripButton optVentas;
        private System.Windows.Forms.ToolStripButton optSalir;
        private System.Windows.Forms.ToolStripButton optResultados;
    }
}