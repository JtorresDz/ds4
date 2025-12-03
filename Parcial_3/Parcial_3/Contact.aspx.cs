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
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarArticulos();
            }
        }
        private void CargarArticulos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbARTICULOS"].ConnectionString;
            string selectSql = "SELECT Id, Titulo, FechaPublicacion, Descripcion, Autor, FechaRegistro FROM Articuloscientificos";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(selectSql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridViewArticulos.DataSource = dt;
                GridViewArticulos.DataBind();
            }
        }

        protected void GridViewArticulos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewArticulos.EditIndex = e.NewEditIndex;
            CargarArticulos();
        }

        protected void GridViewArticulos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewArticulos.EditIndex = -1;
            CargarArticulos();
        }

        protected void GridViewArticulos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridViewArticulos.DataKeys[e.RowIndex].Value);

            GridViewRow row = GridViewArticulos.Rows[e.RowIndex];
            string titulo = ((TextBox)row.Cells[1].Controls[0]).Text;
            string fechaPublicacion = ((TextBox)row.Cells[2].Controls[0]).Text;
            string descripcion = ((TextBox)row.Cells[3].Controls[0]).Text;
            string autor = ((TextBox)row.Cells[4].Controls[0]).Text;

            string connectionString = ConfigurationManager.ConnectionStrings["dbARTICULOS"].ConnectionString;
            string updateSql = "UPDATE Articuloscientificos SET Titulo=@t, FechaPublicacion=@f, Descripcion=@d, Autor=@a WHERE Id=@id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(updateSql, conn))
            {
                cmd.Parameters.AddWithValue("@t", titulo);
                cmd.Parameters.AddWithValue("@f", DateTime.Parse(fechaPublicacion));
                cmd.Parameters.AddWithValue("@d", descripcion);
                cmd.Parameters.AddWithValue("@a", autor);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            GridViewArticulos.EditIndex = -1;
            CargarArticulos();
        }

        protected void GridViewArticulos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridViewArticulos.DataKeys[e.RowIndex].Value);

            string connectionString = ConfigurationManager.ConnectionStrings["dbARTICULOS"].ConnectionString;
            string deleteSql = "DELETE FROM Articuloscientificos WHERE Id=@id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            CargarArticulos();
        }
    }
}