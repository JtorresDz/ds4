namespace Laboratorio123
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.txtSePe = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar la longitud del lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar la longitud del lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar la longitud del lado C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Semiperimetro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Area";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(414, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "Salida";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calcular Semiperimetro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Area del Triangulo";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(266, 25);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(100, 26);
            this.txtLadoA.TabIndex = 9;
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(266, 73);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(100, 26);
            this.txtLadoB.TabIndex = 10;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(266, 123);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(100, 26);
            this.txtLadoC.TabIndex = 11;
            // 
            // txtSePe
            // 
            this.txtSePe.Location = new System.Drawing.Point(266, 254);
            this.txtSePe.Name = "txtSePe";
            this.txtSePe.Size = new System.Drawing.Size(100, 26);
            this.txtSePe.TabIndex = 12;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(266, 303);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 26);
            this.txtArea.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 398);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtSePe);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.TextBox txtSePe;
        private System.Windows.Forms.TextBox txtArea;
    }
}

