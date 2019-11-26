using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploDatabase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ExibirProduto();
        }

        private void ExibirProduto()
        {
            var db = new NorthwindEntities();

            var query = from p in db.Products
                        select new
                        {
                            Produto = p.ProductName,
                            Preço = p.UnitPrice,
                            Categoria = p.Category.CategoryName
                        };

            produtoGridView.DataSource = query.ToList();
            produtoGridView.DataBind();
        }
    }
}