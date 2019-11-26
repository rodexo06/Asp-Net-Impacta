using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploAjax
{
    public partial class ExemploAJAXNet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Page Load: " + DateTime.Now.ToLongTimeString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000); // a classe thread controla os processamentos, assim o sleep, faz ela para por 5000 milisegundos/5 segundos 
            //assim consigo economizar processamento
            mensagemLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}