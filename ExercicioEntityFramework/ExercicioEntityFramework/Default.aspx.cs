using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExercicioEntityFramework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void categoriaButton_Click(object sender, EventArgs e)
        {
            var db = new ProdutoDb();
            categoriaDropDownList.DataValueField = "CategoriaId";
            categoriaDropDownList.DataTextField = "Nome";
            categoriaDropDownList.DataSource = db.CategoriaLista();
            categoriaDropDownList.DataBind();

            categoriaDropDownList.Items.Insert(0, string.Empty);

            MultiView1.ActiveViewIndex = 0;
        }

        protected void categoriaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoriaDropDownList.SelectedIndex == 0)
            {
                produtosGridView.DataSource = null;
            }
            else
            {
                int categoriaId = Convert.ToInt32(categoriaDropDownList.SelectedValue);

                var db = new ProdutoDb();

                var tb = db.ProdutoPorCategoria(categoriaId);
                produtosGridView.DataSource = tb;
                
            }
            produtosGridView.DataBind();
        }

        protected void FornecedorDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FornecedorDropDownList.SelectedIndex == 0)
            {
                produtosGridView.DataSource = null;
            }
            else
            {
                int FornecedorId = Convert.ToInt32(FornecedorDropDownList.SelectedValue);

                var db = new ProdutoDb();

                var tb = db.ProdutosPorFornecedor(FornecedorId);
                produtosGridView.DataSource = tb;

            }
            produtosGridView.DataBind();
        }

        protected void fornecedorButton_Click(object sender, EventArgs e)
        {
            var db = new ProdutoDb();
            FornecedorDropDownList.DataValueField = "FornecedorId";
            FornecedorDropDownList.DataTextField = "Nome";
            FornecedorDropDownList.DataSource = db.FornecedoresLista();
            FornecedorDropDownList.DataBind();

            FornecedorDropDownList.Items.Insert(0, string.Empty);

            MultiView1.ActiveViewIndex = 1;
        }
    }
}