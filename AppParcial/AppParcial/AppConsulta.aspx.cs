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
    public partial class AppConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc10\documents\visual studio 2012\Projects\AppParcial\AppParcial\App_Data\aspnet-AppParcial-20150424190510.mdf;Initial Catalog=aspnet-AppParcial-20150424190510;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            string consulta = "select * from Empleados";

            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);
            DataTable datatable = new DataTable();

            cn.Open();

            int recordsAffected = da.Fill(datatable);
            tabla.DataSource = datatable;
            tabla.DataBind();
            cn.Close();
        }
    }
}