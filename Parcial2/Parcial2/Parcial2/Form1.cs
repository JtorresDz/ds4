using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=Parcial2;Trusted_Connection=True;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void CargarGrid()
        {
            string sql = "SELECT Dato_Inicial, Conversion_a_Farenheit, Conversion_a_Celsius, Conversion_a_Kelvin FROM CNV";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnFarenheit_Click(object sender, EventArgs e)
        {

            double FH = Convert.ToInt32(txtFarenheit.Text);

            double RFF = FH;
            double RFC = ((5.0 / 9.0) * (FH - 32.0));
            double RFK = ((5.0 / 9.0) * (FH - 32.0) + 273.15);

            txtRdeFaF.Text = RFF.ToString("F2");
            txtRdeFaC.Text = RFC.ToString("F2");
            txtRdeFaK.Text = RFK.ToString("F2");

            string insertSql = "INSERT INTO CNV (Dato_Inicial, Conversion_a_Farenheit, Conversion_a_Celsius, Conversion_a_Kelvin) VALUES (@dato, @f, @c, @k)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insertSql, conn))
            {
                cmd.Parameters.AddWithValue("@dato", txtFarenheit.Text);
                cmd.Parameters.AddWithValue("@f", RFF);
                cmd.Parameters.AddWithValue("@c", RFC);
                cmd.Parameters.AddWithValue("@k", RFK);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CargarGrid();
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            double CS = Convert.ToInt32(txtCelsius.Text);

            double RCF = (CS * 9.0 / 5.0) + 32.0; 
            double RCC = CS;
            double RCK = CS + 273.15;

            txtRdeCaF.Text = RCF.ToString("F2");
            txtRdeCaC.Text = RCC.ToString("F2");
            txtRdeCaK.Text = RCK.ToString("F2");

            string insertSql = "INSERT INTO CNV (Dato_Inicial, Conversion_a_Farenheit, Conversion_a_Celsius, Conversion_a_Kelvin) VALUES (@dato, @f, @c, @k)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insertSql, conn))
            {
                cmd.Parameters.AddWithValue("@dato", txtCelsius.Text);
                cmd.Parameters.AddWithValue("@f", RCF);
                cmd.Parameters.AddWithValue("@c", RCC);
                cmd.Parameters.AddWithValue("@k", RCK);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CargarGrid();
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            double KN = Convert.ToInt32(txtKelvin.Text);

            double RKF = (KN - 273.15) * (9.0 / 5.0) + 32.0;
            double RKC = KN - 273.15;
            double RKK = KN;

            txtRdeKaF.Text = RKF.ToString("F2");
            txtRdeKaC.Text = RKC.ToString("F2");
            txtRdeKaK.Text = RKK.ToString("F2");

            string insertSql = "INSERT INTO CNV (Dato_Inicial, Conversion_a_Farenheit, Conversion_a_Celsius, Conversion_a_Kelvin) VALUES (@dato, @f, @c, @k)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insertSql, conn))
            {
                cmd.Parameters.AddWithValue("@dato", txtKelvin.Text);
                cmd.Parameters.AddWithValue("@f", RKF);
                cmd.Parameters.AddWithValue("@c", RKC);
                cmd.Parameters.AddWithValue("@k", RKK);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            CargarGrid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFarenheit.Clear();
            txtCelsius.Clear();
            txtKelvin.Clear();

            txtRdeFaF.Clear();
            txtRdeFaC.Clear();
            txtRdeFaK.Clear();
            

            txtRdeCaF.Clear();
            txtRdeCaC.Clear();
            txtRdeCaK.Clear();

            txtRdeKaF.Clear();
            txtRdeKaC.Clear();
            txtRdeKaK.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
