using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtSePe.Clear();
            txtArea.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ladoA = int.Parse(txtLadoA.Text);
            int ladoB = int.Parse(txtLadoB.Text);
            int ladoC = int.Parse(txtLadoC.Text);
            int semiperimetro = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
             txtArea.Text = area.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ladoA = int.Parse(txtLadoA.Text);
            int ladoB = int.Parse(txtLadoB.Text);
            int ladoC = int.Parse(txtLadoC.Text);
            int semiperimetro = (ladoA + ladoB + ladoC) / 2;
            txtSePe.Text = semiperimetro.ToString();
        }
    }
}
