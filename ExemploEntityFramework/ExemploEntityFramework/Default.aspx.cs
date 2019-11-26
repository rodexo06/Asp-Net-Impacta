using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploEntityFramework
{
    public partial class Default : System.Web.UI.Page
    {

        private void IncluirCliente()
        {
            var cliente = new Cliente
            {
                Nome = NomeTextBox.Text,
                Email = EmailTextBox.Text
            };

            var db = new LojaContext();
            db.Clientes.Add(cliente);
            db.SaveChanges();   
        }

        private void ExibirClientes()
        {
            var db = new LojaContext();
            var lista = db.Clientes.ToList();
            ListaGridView.DataSource = lista;
            ListaGridView.DataBind();
        }



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IncluirButton_Click(object sender, EventArgs e)
        {
            IncluirCliente();
            ExibirClientes();
        }

        protected void ProdutoButton_Click(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            var db = new LojaContext();
            //var query = from c in db.Produtos
            //          select c;

            var query = from c in db.Produtos
                        select new { Produto = c.Nome,
                                     PrecoVenda =  c.Preco,
                                     Categoria = c.CategoriaProduto.Nome,
                                     Desconto = c.Preco*0.2m}; 


            var lista = query.ToList();
            ListaGridView.DataSource = lista;
            ListaGridView.DataBind();

        }
    }
}