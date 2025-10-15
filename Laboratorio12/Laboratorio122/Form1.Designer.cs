namespace Laboratorio122
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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNotaPromedio = new System.Windows.Forms.Label();
            this.txtNP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(157, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nota Promedio";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(58, 111);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(93, 20);
            this.lblNota1.TabIndex = 1;
            this.lblNota1.Text = "NOTA No. 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(58, 174);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(93, 20);
            this.lblNota2.TabIndex = 2;
            this.lblNota2.Text = "NOTA No. 2";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(254, 105);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 26);
            this.txtN1.TabIndex = 3;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(254, 168);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 26);
            this.txtN2.TabIndex = 4;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(254, 232);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 26);
            this.txtN3.TabIndex = 5;
            this.txtN3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(58, 238);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(93, 20);
            this.lblNota3.TabIndex = 6;
            this.lblNota3.Text = "NOTA No. 3";
            // 
            // lblNotaPromedio
            // 
            this.lblNotaPromedio.AutoSize = true;
            this.lblNotaPromedio.Location = new System.Drawing.Point(58, 346);
            this.lblNotaPromedio.Name = "lblNotaPromedio";
            this.lblNotaPromedio.Size = new System.Drawing.Size(114, 20);
            this.lblNotaPromedio.TabIndex = 7;
            this.lblNotaPromedio.Text = "Nota Promedio";
            // 
            // txtNP
            // 
            this.txtNP.Location = new System.Drawing.Point(254, 340);
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(100, 26);
            this.txtNP.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Promedio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 447);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNP);
            this.Controls.Add(this.lblNotaPromedio);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNotaPromedio;
        private System.Windows.Forms.TextBox txtNP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

