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


    public partial class Shippers : System.Web.UI.Page
    {

        string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;
                            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ExibirTransportadoras();
            }
        }

        private void ExibirTransportadoras()
        {
            string sql = "Select ShipperId, CompanyName, Phone From Shippers";

            using (var cn = new SqlConnection(conexao))
            {
                var cmd = new SqlCommand(sql, cn);
                cn.Open();
                listaGridView1.DataSource = cmd.ExecuteReader();
                listaGridView1.DataBind();  
            }
        }

        protected void incluirButton_Click(object sender, EventArgs e)
        {
            IncluirTransportadora();
            ExibirTransportadoras();
        }

        private void IncluirTransportadora()
        {
            try { 
            string sql = @"Insert into Shippers(CompanyName, Phone) 
                           Values(@Nome, @Telefone) 
                           Select @@IDENTITY";

                using (var cn = new SqlConnection(conexao))
                {
                    var cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@Nome", nomeTextBox.Text);
                    cmd.Parameters.AddWithValue("@Telefone", telefoneTextBox.Text);

                    cn.Open();
                    int id = Convert.ToInt32( cmd.ExecuteScalar());
                    mensagemLabel.Text = "Foi inserido com sucesso, Id = " + id;
                }
            }
            catch { mensagemLabel.Text = "Deu ruim"; }
        }
    }
}