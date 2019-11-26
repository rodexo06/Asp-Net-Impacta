using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ExemploManipImg
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviarButton_Click(object sender, EventArgs e)
        {

            try
            {
                var bitmap = new System.Drawing.Bitmap(imagemFileUpload.FileContent);
            }
            catch
            {
                mensagemLabel.Text = "deu ruim";
                return;
            }
            string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;
                                      Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            byte[] foto = imagemFileUpload.FileBytes;
            string nomeCat = categoriaTextBox.Text;
            string sql = "INSERT INTO Categories(CategoryName, Picture) values (@nome, @foto)";
            using (var cn = new SqlConnection(conexao))
            {
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nome", nomeCat);
                cmd.Parameters.AddWithValue("@foto", foto);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            mensagemLabel.Text = ("liso");
        }
    }
}


//if (imagemFileUpload.HasFile)
//{
//    string arquivo = imagemFileUpload.FileName;
//    string caminhoVirtual = "~/img/" + arquivo;
//    string caminhoFisico = Server.MapPath(caminhoVirtual);

//    //Gravar
//    imagemFileUpload.SaveAs(caminhoFisico);

//    //Exibir
//    image.ImageUrl = caminhoVirtual;
//    mensagemLabel.Text = "Gravado em " + caminhoFisico;
//}
//else
//{
//    mensagemLabel.Text = "errou";
//}
