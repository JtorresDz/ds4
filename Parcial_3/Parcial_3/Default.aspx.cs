using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial_3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void buscar_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = nombreB.Text.Trim();
            DataTable resultados = BuscarArticuloPorNombre(nombreBusqueda);
            GridViewResultados.DataSource = resultados;
            GridViewResultados.DataBind();
            if (resultados.Rows.Count == 0)
            {
                lblResultado.Text = "No se encontraron artículos con ese nombre.";
            }
            else
            {
                lblResultado.Text = $"{resultados.Rows.Count} artículo(s) encontrado(s).";
            }
        }
        private DataTable BuscarArticuloPorNombre(string nombre)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbARTICULOS"].ConnectionString;
            string selectSql = "SELECT Id, Titulo, FechaPublicacion, Descripcion, Autor, FechaRegistro " +
                               "FROM Articuloscientificos WHERE Titulo LIKE @nombre";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(selectSql, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

    }
}