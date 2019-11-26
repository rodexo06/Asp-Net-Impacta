using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ExemploADO
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clienteButton_Click(object sender, EventArgs e)
        {
            ExibirCliente();
        }

        private void ExibirCliente()
        {
            string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                    TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sql = "Select CustomerId,CompanyName from Customers";

            //Dbconnection, dbcommand, dbdatareader

            //DBconnection 
            //  ConnectString
            //  Open()
            //  Close()

            using (var cn = new SqlConnection(conexao))
            {
                using(var cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        listaListBox.DataSource = dataReader;
                        listaListBox.DataBind();
                    }
                    
                }

            }


            //DBCommand
            //  Connection
            //  CommandText(sql
            //  ExecuteReader()
            //var cmd = new SqlCommand();
            // cmd.Connection = cn;
            //cmd.CommandText = "Select CompanyName, Phone From Customers";

            //DbDataReader
            //  this[int] indexador, qual é o index dele na tabela
            //  this[String] nome da coluna
            /*  read() Somente Leitura e sempre pra frente

            SqlDataReader dr = cmd.ExecuteReader(); //é so um comando, ele n le nada

            while(dr.Read()) //aqui ele carrega um registro, a partir do index
            {
                //string nome = dr["CompanyName"].ToString(); //ele retorna objeto, por isso o string
                listaListBox.Items.Add(nome);
            }

            dr.Close();
            cn.Close();
            */
            listaListBox.Visible = true;
            
        }

        protected void listaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mensagemLabel.Text = "Foi escolhido" + listaListBox.SelectedValue;
        }
    }
}