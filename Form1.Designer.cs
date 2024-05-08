namespace Estructura_de_datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.listaEnlazadaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDoblementeEnlazadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasRamificadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioDeBusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.grafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.sistemasLToolStripMenuItem,
            this.estructurasRamificadasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelDesarrolladorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // datosDelDesarrolladorToolStripMenuItem
            // 
            this.datosDelDesarrolladorToolStripMenuItem.Name = "datosDelDesarrolladorToolStripMenuItem";
            this.datosDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.datosDelDesarrolladorToolStripMenuItem.Text = "Datos del desarrollador";
            this.datosDelDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.datosDelDesarrolladorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // sistemasLToolStripMenuItem
            // 
            this.sistemasLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.listaEnlazadaSimpleToolStripMenuItem,
            this.listaDoblementeEnlazadaToolStripMenuItem});
            this.sistemasLToolStripMenuItem.Name = "sistemasLToolStripMenuItem";
            this.sistemasLToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.sistemasLToolStripMenuItem.Text = "Estructuras lineales";
            this.sistemasLToolStripMenuItem.Click += new System.EventHandler(this.sistemasLToolStripMenuItem_Click);
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.colaToolStripMenuItem.Text = "Cola...";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.pilaToolStripMenuItem.Text = "Pila...";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
            // 
            // listaEnlazadaSimpleToolStripMenuItem
            // 
            this.listaEnlazadaSimpleToolStripMenuItem.Name = "listaEnlazadaSimpleToolStripMenuItem";
            this.listaEnlazadaSimpleToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.listaEnlazadaSimpleToolStripMenuItem.Text = "Lista enlazada simple...";
            this.listaEnlazadaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaSimpleToolStripMenuItem_Click);
            // 
            // listaDoblementeEnlazadaToolStripMenuItem
            // 
            this.listaDoblementeEnlazadaToolStripMenuItem.Name = "listaDoblementeEnlazadaToolStripMenuItem";
            this.listaDoblementeEnlazadaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.listaDoblementeEnlazadaToolStripMenuItem.Text = "Lista doblemente enlazada";
            this.listaDoblementeEnlazadaToolStripMenuItem.Click += new System.EventHandler(this.listaDoblementeEnlazadaToolStripMenuItem_Click);
            // 
            // estructurasRamificadasToolStripMenuItem
            // 
            this.estructurasRamificadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolBinarioDeBusquedaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.grafoToolStripMenuItem});
            this.estructurasRamificadasToolStripMenuItem.Name = "estructurasRamificadasToolStripMenuItem";
            this.estructurasRamificadasToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.estructurasRamificadasToolStripMenuItem.Text = "Estructuras ramificadas";
            // 
            // arbolBinarioDeBusquedaToolStripMenuItem
            // 
            this.arbolBinarioDeBusquedaToolStripMenuItem.Name = "arbolBinarioDeBusquedaToolStripMenuItem";
            this.arbolBinarioDeBusquedaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.arbolBinarioDeBusquedaToolStripMenuItem.Text = "Arbol binario de busqueda";
            this.arbolBinarioDeBusquedaToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioDeBusquedaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(211, 6);
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.grafoToolStripMenuItem.Text = "Grafo";
            this.grafoToolStripMenuItem.Click += new System.EventHandler(this.grafoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos - Estructura dinamica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemasLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDoblementeEnlazadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasRamificadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioDeBusquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem;
    }
}

