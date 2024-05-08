namespace Estructura_de_datos
{
    partial class frmArbol
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElementos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstArbolPreOrden = new System.Windows.Forms.ListBox();
            this.lstArbolInOrden = new System.Windows.Forms.ListBox();
            this.lstArbolPostOrden = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbElementos = new System.Windows.Forms.ComboBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(77, 156);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(143, 20);
            this.txtTramite.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(120, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tramite:";
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(29, 35);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(59, 13);
            this.lblElementos.TabIndex = 6;
            this.lblElementos.Text = "Elementos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEquilibrar);
            this.groupBox1.Controls.Add(this.cmbElementos);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.lblElementos);
            this.groupBox1.Location = new System.Drawing.Point(549, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 258);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elemento Eliminado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtTramite);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(284, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 258);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Elemento";
            // 
            // lstArbolPreOrden
            // 
            this.lstArbolPreOrden.FormattingEnabled = true;
            this.lstArbolPreOrden.Location = new System.Drawing.Point(284, 303);
            this.lstArbolPreOrden.Name = "lstArbolPreOrden";
            this.lstArbolPreOrden.Size = new System.Drawing.Size(248, 199);
            this.lstArbolPreOrden.TabIndex = 9;
            // 
            // lstArbolInOrden
            // 
            this.lstArbolInOrden.FormattingEnabled = true;
            this.lstArbolInOrden.Location = new System.Drawing.Point(21, 303);
            this.lstArbolInOrden.Name = "lstArbolInOrden";
            this.lstArbolInOrden.Size = new System.Drawing.Size(248, 199);
            this.lstArbolInOrden.TabIndex = 10;
            // 
            // lstArbolPostOrden
            // 
            this.lstArbolPostOrden.FormattingEnabled = true;
            this.lstArbolPostOrden.Location = new System.Drawing.Point(549, 303);
            this.lstArbolPostOrden.Name = "lstArbolPostOrden";
            this.lstArbolPostOrden.Size = new System.Drawing.Size(248, 199);
            this.lstArbolPostOrden.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(23, 142);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(190, 47);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(23, 83);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 44);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cmbElementos
            // 
            this.cmbElementos.FormattingEnabled = true;
            this.cmbElementos.Location = new System.Drawing.Point(101, 27);
            this.cmbElementos.Name = "cmbElementos";
            this.cmbElementos.Size = new System.Drawing.Size(121, 21);
            this.cmbElementos.TabIndex = 16;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(23, 205);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(190, 47);
            this.btnEquilibrar.TabIndex = 17;
            this.btnEquilibrar.Text = "Equiilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(190, 47);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 520);
            this.Controls.Add(this.lstArbolPostOrden);
            this.Controls.Add(this.lstArbolInOrden);
            this.Controls.Add(this.lstArbolPreOrden);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmArbol";
            this.Text = "frmArbol";
            this.Load += new System.EventHandler(this.frmArbol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbElementos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstArbolPreOrden;
        private System.Windows.Forms.ListBox lstArbolInOrden;
        private System.Windows.Forms.ListBox lstArbolPostOrden;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.Button btnAgregar;
    }
}