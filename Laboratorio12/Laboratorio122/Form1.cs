using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtNP.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, np;
            n1 = Convert.ToInt32(txtN1.Text);
            n2 = Convert.ToInt32(txtN2.Text);
            n3 = Convert.ToInt32(txtN3.Text);
            np = (n1 + n2 + n3) / 3;
            txtNP.Text = Convert.ToString(np);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();   
        }
    }
}
