
namespace MATRIZ_ALEATORIA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fila = new System.Windows.Forms.TextBox();
            this.txt_columna = new System.Windows.Forms.TextBox();
            this.btn_crearmatriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO DE FILAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO DE COLUMNAS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "CREE LA MATRIZ";
            // 
            // txt_fila
            // 
            this.txt_fila.Location = new System.Drawing.Point(189, 60);
            this.txt_fila.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_fila.Name = "txt_fila";
            this.txt_fila.Size = new System.Drawing.Size(84, 21);
            this.txt_fila.TabIndex = 3;
            // 
            // txt_columna
            // 
            this.txt_columna.Location = new System.Drawing.Point(189, 105);
            this.txt_columna.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_columna.Name = "txt_columna";
            this.txt_columna.Size = new System.Drawing.Size(84, 21);
            this.txt_columna.TabIndex = 4;
            // 
            // btn_crearmatriz
            // 
            this.btn_crearmatriz.Location = new System.Drawing.Point(115, 150);
            this.btn_crearmatriz.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_crearmatriz.Name = "btn_crearmatriz";
            this.btn_crearmatriz.Size = new System.Drawing.Size(97, 62);
            this.btn_crearmatriz.TabIndex = 5;
            this.btn_crearmatriz.Text = "CREAR MATRIZ";
            this.btn_crearmatriz.UseVisualStyleBackColor = true;
            this.btn_crearmatriz.Click += new System.EventHandler(this.btn_crearmatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(335, 237);
            this.Controls.Add(this.btn_crearmatriz);
            this.Controls.Add(this.txt_columna);
            this.Controls.Add(this.txt_fila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fila;
        private System.Windows.Forms.TextBox txt_columna;
        private System.Windows.Forms.Button btn_crearmatriz;
    }
}

