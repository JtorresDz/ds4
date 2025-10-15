namespace Laboratorio12
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(212, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Laboratorio121";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(34, 129);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(243, 20);
            this.lblVelocidad.TabIndex = 1;
            this.lblVelocidad.Text = "Ingrese la velocidad del vehiculo: ";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(34, 205);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(295, 20);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Ingrese el tiempo utilizado del vechiculo: \r\n";
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(373, 123);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(100, 26);
            this.txtVelocidad.TabIndex = 3;
            this.txtVelocidad.TextChanged += new System.EventHandler(this.txtVelocidad_TextChanged);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(373, 199);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 26);
            this.txtTiempo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular distancia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 68);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar pantalla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(367, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 68);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cerrar programa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(34, 362);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(207, 20);
            this.lblDistancia.TabIndex = 8;
            this.lblDistancia.Text = "Total de distancia recorrida: \r\n";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(373, 356);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 26);
            this.txtDistancia.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 428);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtDistancia;
    }
}

