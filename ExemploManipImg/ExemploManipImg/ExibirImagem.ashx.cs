using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.IO;

namespace ExemploManipImg
{
    /// <summary>
    /// Descrição resumida de ExibirImagem
    /// </summary>
    public class ExibirImagem : IHttpHandler
    {



        public void ProcessRequest(HttpContext context)
        {
            int Id = 0;
            if (!int.TryParse(context.Request.QueryString["EmployeeID"], out Id))
            {
                return;
            }

            if (Id == 0)
            {
                return;
            }


            string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;
                                      Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sql = " select Photo from Employees where EmployeeID = @Id ";
            byte[] foto = null;

            using (var cn = new SqlConnection(conexao))
            {
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cn.Open();
                foto = (byte[])cmd.ExecuteScalar();
            }

            int offset = 78;
            var a = new MemoryStream(foto, offset, foto.Length - offset);
            var fotoNorthwind = a.ToArray();

            context.Response.ContentType = "image/jpeg";
            context.Response.BinaryWrite(fotoNorthwind);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}

//public void ProcessRequest(HttpContext context)
//{
//    int categoriaId = 0;
//    if (!int.TryParse(context.Request.QueryString["categoriaId"], out categoriaId))
//    {
//        return;
//    }

//    if (categoriaId == 0)
//    {
//        return;
//    }


//    string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;
//                              Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
//    string sql = " select Picture from Categories where  CategoryId = @categoriaId ";
//    byte[] foto = null;

//    using (var cn = new SqlConnection(conexao))
//    {
//        var cmd = new SqlCommand(sql, cn);
//        cmd.Parameters.AddWithValue("@categoriaId", categoriaId);
//        cn.Open();
//        foto = (byte[])cmd.ExecuteScalar();
//    }

//    int offset = 78;
//    var a = new MemoryStream(foto, offset, foto.Length - offset);
//    var fotoNorthwind = a.ToArray();

//    context.Response.ContentType = "image/jpeg";
//    context.Response.BinaryWrite(fotoNorthwind);
//}