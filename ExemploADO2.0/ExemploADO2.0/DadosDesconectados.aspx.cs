using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace ExemploADO2._0
{
    public partial class DadosDesconectados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dataTableButton_Click(object sender, EventArgs e)
        {

            //Vincular
            listaGridView.AllowPaging = true;
            listaGridView.PageSize = 6;
            listaGridView.DataSource = ObterDados();
            listaGridView.DataBind();

        }

        DataTable ObterDados()
        {
            ////Criar um data table
            //var tabela = new DataTable();

            //// adicionar colunas 
            //tabela.Columns.Add("Nome");
            //tabela.Columns.Add("Email");
            //tabela.Columns.Add("Idade", typeof(int));

            ////adicionar Registros /Linhas
            //tabela.Rows.Add("Jose da silva", "Jose@hotmail", 18);
            //tabela.Rows.Add("maria da sila", "maria@gmail", 20);
            //tabela.Rows.Add("Jose da silva", "Jose@hotmail", 18);
            //tabela.Rows.Add("maria da sila", "maria@gmail", 20);
            //tabela.Rows.Add("Jose da silva", "Jose@hotmail", 18);
            //tabela.Rows.Add("maria da sila", "maria@gmail", 20);
            //tabela.Rows.Add("Jose da silva", "Jose@hotmail", 18);
            //tabela.Rows.Add("maria da sila", "maria@gmail", 20);
            //tabela.Rows.Add("Jose da silva", "Jose@hotmail", 18);
            //tabela.Rows.Add("maria da sila", "maria@gmail", 20);
            //tabela.Rows.Add("Jose da silva", "Jose@hotmail", 18);
            //tabela.Rows.Add("maria da sila", "maria@gmail", 20);
            //tabela.Rows.Add("Jose da silva", "Jose@hotmail", 18);
            //tabela.Rows.Add("maria da sila", "maria@gmail", 20);
            //tabela.Rows.Add("Jose da silva", "Jose@hotmail", 18);
            //tabela.Rows.Add("maria da sila", "maria@gmail", 20);

            //return tabela;

            string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;
                            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sql = "Select CompanyName, Phone, City, Country From Customers";

            var da = new SqlDataAdapter(sql, conexao);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            var tabela = new DataTable();
            //Abre a conexão com o banco verifica a qtd de colunas, abre o data reader, joga a linham enfim faz tudo de cima 
            da.Fill(tabela);

            return tabela;





        }

        protected void listaGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            listaGridView.PageIndex = e.NewPageIndex;
            listaGridView.DataSource = ObterDados();
            listaGridView.DataBind();
        }

    }
}
