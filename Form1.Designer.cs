namespace Prueba {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.LblFichero = new System.Windows.Forms.Label();
            this.LblTexto = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.TBTexto = new System.Windows.Forms.TextBox();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TBResultados = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(12, 12);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(75, 23);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir Fichero";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // LblFichero
            // 
            this.LblFichero.AutoSize = true;
            this.LblFichero.Location = new System.Drawing.Point(99, 17);
            this.LblFichero.Name = "LblFichero";
            this.LblFichero.Size = new System.Drawing.Size(142, 13);
            this.LblFichero.TabIndex = 1;
            this.LblFichero.Text = "Ningun fichero seleccionado";
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.Location = new System.Drawing.Point(13, 47);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(78, 13);
            this.LblTexto.TabIndex = 2;
            this.LblTexto.Text = "Texto a buscar";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(13, 73);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(84, 13);
            this.lblCiudad.TabIndex = 3;
            this.lblCiudad.Text = "Ciudad a buscar";
            // 
            // TBTexto
            // 
            this.TBTexto.Location = new System.Drawing.Point(103, 44);
            this.TBTexto.Name = "TBTexto";
            this.TBTexto.Size = new System.Drawing.Size(100, 20);
            this.TBTexto.TabIndex = 4;
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(103, 70);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(100, 20);
            this.TBCiudad.TabIndex = 5;
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(209, 42);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(129, 23);
            this.BtnListar.TabIndex = 6;
            this.BtnListar.Text = "Listar (texto)";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(209, 68);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(129, 23);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar (texto, ciudad)";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TBResultados
            // 
            this.TBResultados.Location = new System.Drawing.Point(9, 97);
            this.TBResultados.MaxLength = 2147483647;
            this.TBResultados.Multiline = true;
            this.TBResultados.Name = "TBResultados";
            this.TBResultados.ReadOnly = true;
            this.TBResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBResultados.Size = new System.Drawing.Size(337, 383);
            this.TBResultados.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 486);
            this.Controls.Add(this.TBResultados);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.TBCiudad);
            this.Controls.Add(this.TBTexto);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.LblFichero);
            this.Controls.Add(this.BtnAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Label LblFichero;
        private System.Windows.Forms.Label LblTexto;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox TBTexto;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TBResultados;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

