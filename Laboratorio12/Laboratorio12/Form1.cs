using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtVelocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtVelocidad.Text);
            int num2 = Convert.ToInt32(txtTiempo.Text);
            int resultado = num1 * num2;
            txtDistancia.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTiempo.Clear();
            txtVelocidad.Clear();
            txtDistancia.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
