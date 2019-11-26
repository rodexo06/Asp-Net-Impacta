using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ExemploADO2._0
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelEntrada.Text = " ";
        }

        protected void pesquisarButton_Click(object sender, EventArgs e)
        {
            try {
                PesquisarPais();
            }
            catch {
                labelEntrada.Text = "Não funcionou";
            }
        }

        private void PesquisarPais()
        {
            string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;
                            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (var cn = new SqlConnection(conexao))
            {
                using(var cmd = new SqlCommand("ClientePesquisaPorPais", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pais", paisTextBox.Text);
                    cn.Open();

                    try
                    {
                        var datareader = cmd.ExecuteReader();
                        listaGridView.DataSource = datareader;
                        listaGridView.DataBind();
                    }
                    catch {
                        labelEntrada.Text = "Não funcionou 2 ";
                    }
                }
            }
        }
    }
}