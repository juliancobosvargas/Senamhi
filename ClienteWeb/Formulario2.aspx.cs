using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class Formulario2 : System.Web.UI.Page
    {
        private ServicioReferencia1.ServicioWebSoapClient Servicio;
        protected void Page_Load(object sender, EventArgs e)
        {
            Servicio = new ServicioReferencia1.ServicioWebSoapClient();
            GridViewTiempo.AutoGenerateColumns = true;
            GridViewTiempo.DataSource = Servicio.ListarTTiempo().Tables[0];
            GridViewTiempo.DataBind();
        }
        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string Lugar = TxtDepartamento.Text.Trim();
            Servicio = new ServicioReferencia1.ServicioWebSoapClient();
            GridViewTiempo.AutoGenerateColumns = true;
            GridViewTiempo.DataSource = Servicio.ListarDepartamento(Lugar).Tables[0];
            GridViewTiempo.DataBind();
        }
    }
}