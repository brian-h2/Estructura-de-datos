namespace Estructura_de_datos
{
    partial class frmBaseDeDatos
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionMultiAtributo = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnSeleccionPorConvolucion = new System.Windows.Forms.Button();
            this.btnSeleccionMultiAtributo = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(24, 24);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(700, 315);
            this.dgvDatos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operaciones de Proyeccion - SELECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operaciones de Seleccion - WHERE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operaciones Algebraicas";
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(40, 411);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(160, 23);
            this.btnProyeccionSimple.TabIndex = 4;
            this.btnProyeccionSimple.Text = "Proyeccion Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(308, 411);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(160, 23);
            this.btnSeleccionSimple.TabIndex = 5;
            this.btnSeleccionSimple.Text = "Seleccion Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(40, 469);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(160, 23);
            this.btnJuntar.TabIndex = 6;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnProyeccionMultiAtributo
            // 
            this.btnProyeccionMultiAtributo.Location = new System.Drawing.Point(40, 440);
            this.btnProyeccionMultiAtributo.Name = "btnProyeccionMultiAtributo";
            this.btnProyeccionMultiAtributo.Size = new System.Drawing.Size(160, 23);
            this.btnProyeccionMultiAtributo.TabIndex = 7;
            this.btnProyeccionMultiAtributo.Text = "Proyeccion Multiatributo";
            this.btnProyeccionMultiAtributo.UseVisualStyleBackColor = true;
            this.btnProyeccionMultiAtributo.Click += new System.EventHandler(this.btnProyeccionMultiAtributo_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(564, 469);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(160, 23);
            this.btnDiferencia.TabIndex = 8;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionPorConvolucion
            // 
            this.btnSeleccionPorConvolucion.Location = new System.Drawing.Point(308, 469);
            this.btnSeleccionPorConvolucion.Name = "btnSeleccionPorConvolucion";
            this.btnSeleccionPorConvolucion.Size = new System.Drawing.Size(160, 23);
            this.btnSeleccionPorConvolucion.TabIndex = 9;
            this.btnSeleccionPorConvolucion.Text = "Seleccion por convolucion";
            this.btnSeleccionPorConvolucion.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionMultiAtributo
            // 
            this.btnSeleccionMultiAtributo.Location = new System.Drawing.Point(308, 440);
            this.btnSeleccionMultiAtributo.Name = "btnSeleccionMultiAtributo";
            this.btnSeleccionMultiAtributo.Size = new System.Drawing.Size(160, 23);
            this.btnSeleccionMultiAtributo.TabIndex = 10;
            this.btnSeleccionMultiAtributo.Text = "Seleccion MultiAtributo";
            this.btnSeleccionMultiAtributo.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiAtributo.Click += new System.EventHandler(this.btnSeleccionMultiAtributo_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(564, 440);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(160, 23);
            this.btnInterseccion.TabIndex = 11;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(564, 411);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(160, 23);
            this.btnUnion.TabIndex = 12;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.btnInterseccion);
            this.Controls.Add(this.btnSeleccionMultiAtributo);
            this.Controls.Add(this.btnSeleccionPorConvolucion);
            this.Controls.Add(this.btnDiferencia);
            this.Controls.Add(this.btnProyeccionMultiAtributo);
            this.Controls.Add(this.btnJuntar);
            this.Controls.Add(this.btnSeleccionSimple);
            this.Controls.Add(this.btnProyeccionSimple);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmBaseDeDatos";
            this.Text = "frmBaseDeDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMultiAtributo;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnSeleccionPorConvolucion;
        private System.Windows.Forms.Button btnSeleccionMultiAtributo;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}