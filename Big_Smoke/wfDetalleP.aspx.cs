using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Big_Smoke
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfAcceso.aspx");
        }
    }
}