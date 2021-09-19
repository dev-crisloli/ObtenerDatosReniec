
namespace Ejemplo
{
    partial class FormSunat
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
            this.txt_buscarDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.Nombres = new System.Windows.Forms.Label();
            this.txt_segundoApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_primerApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_codigoVerificador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_buscarDNI
            // 
            this.txt_buscarDNI.Location = new System.Drawing.Point(35, 67);
            this.txt_buscarDNI.Name = "txt_buscarDNI";
            this.txt_buscarDNI.Size = new System.Drawing.Size(572, 27);
            this.txt_buscarDNI.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Buscar por DNI";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(210, 213);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.ReadOnly = true;
            this.txt_nombres.Size = new System.Drawing.Size(397, 27);
            this.txt_nombres.TabIndex = 26;
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.Location = new System.Drawing.Point(35, 213);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(111, 20);
            this.Nombres.TabIndex = 25;
            this.Nombres.Text = "Primer Nombre";
            // 
            // txt_segundoApellido
            // 
            this.txt_segundoApellido.Location = new System.Drawing.Point(210, 164);
            this.txt_segundoApellido.Name = "txt_segundoApellido";
            this.txt_segundoApellido.ReadOnly = true;
            this.txt_segundoApellido.Size = new System.Drawing.Size(397, 27);
            this.txt_segundoApellido.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Segundo Apellido";
            // 
            // txt_primerApellido
            // 
            this.txt_primerApellido.Location = new System.Drawing.Point(210, 121);
            this.txt_primerApellido.Name = "txt_primerApellido";
            this.txt_primerApellido.ReadOnly = true;
            this.txt_primerApellido.Size = new System.Drawing.Size(397, 27);
            this.txt_primerApellido.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Primer Apellido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Capturar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_codigoVerificador
            // 
            this.txt_codigoVerificador.Location = new System.Drawing.Point(210, 260);
            this.txt_codigoVerificador.Name = "txt_codigoVerificador";
            this.txt_codigoVerificador.ReadOnly = true;
            this.txt_codigoVerificador.Size = new System.Drawing.Size(397, 27);
            this.txt_codigoVerificador.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Codigo Verificador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(533, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Desarrollado por Cristopher Loli - crisloli@gmail.com - YAPE o PLIN 992581989";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormSunat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 396);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_codigoVerificador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_buscarDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.txt_segundoApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_primerApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormSunat";
            this.Text = "FormSunat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_buscarDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.TextBox txt_segundoApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_primerApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_codigoVerificador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}