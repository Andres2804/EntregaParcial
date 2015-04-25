using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AppParcial
{
    public partial class AppActualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string domicilio = txtDomicilio.Text;
            string ciudad = txtCiudad.Text;
            string telefono = txtTelefono.Text;

            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc10\documents\visual studio 2012\Projects\AppParcial\AppParcial\App_Data\aspnet-AppParcial-20150424190510.mdf;Initial Catalog=aspnet-AppParcial-20150424190510;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();

            string consulta = "update Empleados set nombre='" + nombre + "','" + correo + "','" + domicilio + "','" + ciudad + "','" + telefono + "')";
            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
            SqlCommand comando = new SqlCommand(consulta, cn);

            comando.ExecuteNonQuery();
            cn.Close();

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtDomicilio.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text;
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc10\documents\visual studio 2012\Projects\AppParcial\AppParcial\App_Data\aspnet-AppParcial-20150424190510.mdf;Initial Catalog=aspnet-AppParcial-20150424190510;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();
            string consulta = "select* from Empleados where cedula='" + buscar + "'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
            DataTable datatable = new DataTable();
            txtCedula.Text = buscar;

            int recordsAffected = da.Fill(datatable);
            gridtabla.DataSource = datatable;
            gridtabla.DataBind();
            cn.Close();


        }
    }
}