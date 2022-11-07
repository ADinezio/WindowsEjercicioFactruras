namespace WindowsEjercicioFactruras
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
            this.btnCrearObjetos = new System.Windows.Forms.Button();
            this.lblCaso7 = new System.Windows.Forms.Label();
            this.btnMostrarObjetos = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCrearObjetos
            // 
            this.btnCrearObjetos.Location = new System.Drawing.Point(235, 77);
            this.btnCrearObjetos.Name = "btnCrearObjetos";
            this.btnCrearObjetos.Size = new System.Drawing.Size(183, 39);
            this.btnCrearObjetos.TabIndex = 0;
            this.btnCrearObjetos.Text = "Crear Objetos";
            this.btnCrearObjetos.UseVisualStyleBackColor = true;
            this.btnCrearObjetos.Click += new System.EventHandler(this.btnCrearObjetos_Click);
            // 
            // lblCaso7
            // 
            this.lblCaso7.AutoSize = true;
            this.lblCaso7.Location = new System.Drawing.Point(411, 47);
            this.lblCaso7.Name = "lblCaso7";
            this.lblCaso7.Size = new System.Drawing.Size(40, 13);
            this.lblCaso7.TabIndex = 1;
            this.lblCaso7.Text = "Caso 7";
            // 
            // btnMostrarObjetos
            // 
            this.btnMostrarObjetos.Location = new System.Drawing.Point(452, 77);
            this.btnMostrarObjetos.Name = "btnMostrarObjetos";
            this.btnMostrarObjetos.Size = new System.Drawing.Size(183, 39);
            this.btnMostrarObjetos.TabIndex = 2;
            this.btnMostrarObjetos.Text = "Mostrar Objetos";
            this.btnMostrarObjetos.UseVisualStyleBackColor = true;
            this.btnMostrarObjetos.Click += new System.EventHandler(this.btnMostrarObjetos_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(235, 187);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(400, 134);
            this.lstProductos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnMostrarObjetos);
            this.Controls.Add(this.lblCaso7);
            this.Controls.Add(this.btnCrearObjetos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearObjetos;
        private System.Windows.Forms.Label lblCaso7;
        private System.Windows.Forms.Button btnMostrarObjetos;
        private System.Windows.Forms.ListBox lstProductos;
    }
}

