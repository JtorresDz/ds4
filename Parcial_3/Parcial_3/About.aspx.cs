using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Parcial_3
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void almacenar_Click(object sender, EventArgs e)
        {
            string nombreAr = nombreA.Text.ToLower();
            string descripcionAr = descripcionA.Text.ToLower();
            string autorAr = autorA.Text.ToLower();

            DateTime fechaAr;
            if (!DateTime.TryParse(fechaA.Text, out fechaAr))
            {
                fechaAr = DateTime.Now;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["dbARTICULOS"].ConnectionString;

            string insertSql = "INSERT INTO Articuloscientificos (Titulo, FechaPublicacion, Descripcion, Autor) VALUES (@t, @fb, @d, @a)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insertSql, conn))
            {
                cmd.Parameters.Add("@t", SqlDbType.NVarChar).Value = nombreAr;
                cmd.Parameters.Add("@fb", SqlDbType.DateTime).Value = fechaAr;
                cmd.Parameters.Add("@d", SqlDbType.NVarChar).Value = descripcionAr;
                cmd.Parameters.Add("@a", SqlDbType.NVarChar).Value = autorAr;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            lblMensaje.Text = "El artículo fue guardado correctamente.";
        }

    }
}