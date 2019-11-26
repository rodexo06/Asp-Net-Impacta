using System;
using ExercicioModelFirst.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExercicioModelFirst
{
    public partial class Editora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            editorasGridView.DataSource = BibliotecaDb.EditorasLista();
            editorasGridView.DataBind();
        }
    }
}