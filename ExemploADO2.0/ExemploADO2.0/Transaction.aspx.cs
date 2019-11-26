using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploADO2._0
{
    public partial class Transaction : System.Web.UI.Page
    {
        string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;
                            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                VincularProdutos(produtoInserirDropDownList);
                VincularProdutos(produtoRetirarDropDownList);
                ExibirEstoque();
            }
        }

        private void ExibirEstoque()
        {

            int produto1Id = Convert.ToInt32(produtoRetirarDropDownList.SelectedValue);
            produtoLabel.Text = ObterEstoque(produto1Id).ToString();

            int produto2Id = Convert.ToInt32(produtoRetirarDropDownList.SelectedValue);
            produto2Label.Text = ObterEstoque(produto1Id).ToString();
        }

        private int ObterEstoque(int produtoid)
        {
            int retorno = 0;
            using (var cn = new SqlConnection(conexao))
            {
                using (var cmd = new SqlCommand("ProdutoObterEstoque", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@produtoId", produtoid);
                    cn.Open();
                    retorno = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return retorno;
        }

        private void VincularProdutos(DropDownList control)
        {
            using (var cn = new SqlConnection(conexao))
            {
                var cmd = new SqlCommand("ProdutoListar", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                    control.DataSource = cmd.ExecuteReader();
                    control.DataBind();
            }
        }

        protected void ProdutoRetirarDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirEstoque();
        }

        protected void ProdutoInserirDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirEstoque();
        }

        protected void ExecuteButton_Click(object sender, EventArgs e)
        {
            ExecutarTransferencia();
            ExibirEstoque();
        }

        private void ExecutarTransferencia()
        {
            SqlConnection cn = null;
            SqlCommand cmd1, cmd2;
            SqlTransaction t = null;

            try
            {
                int produtoId1 = Convert.ToInt32(produtoRetirarDropDownList.SelectedValue), produtoId2 = Convert.ToInt32(produtoInserirDropDownList.SelectedValue);


                using (cn = new SqlConnection(conexao))
                {
                    cn.Open();

                    //criar uma transação(sql transaction)
                    t = cn.BeginTransaction();

                    //Inscrever os comandos da transação
                    cmd1 = new SqlCommand("ProdutoRetirarnoEstoque", cn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@produtoId", produtoId1);
                    cmd1.Transaction = t;

                    cmd2 = new SqlCommand("ProdutoIncluirnoEstoque", cn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@produtoId", produtoId2);
                    cmd2.Transaction = t;

                    //Executar os comandos
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    //gravar
                    t.Commit();
                }
                mensagemLabel.Text = "Boa Vaqueiro";
            }
            catch (Exception)
            {
                //Cancelar
                t.Rollback();
                mensagemLabel.Text = "Deu ruim parceiro";
            }
            finally
            {
                if (cn != null) cn.Close();
            }
        }


    }
}