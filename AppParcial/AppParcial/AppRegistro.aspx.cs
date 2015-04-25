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
    public partial class AppRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
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
            
            string consulta = "insert into Empleados(Cedula,Nombre,Correo,Domicilio,Ciudad,Telefono)values('" + cedula + "','"+nombre+"','"+ correo +"','"+domicilio+"','"+ciudad+"','"+telefono+"')";
            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
            SqlCommand comando = new SqlCommand(consulta, cn);

            comando.ExecuteNonQuery();
            cn.Close();

            
        }
    }
}