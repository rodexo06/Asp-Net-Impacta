using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioADO1
{
    public class Northwind
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;
                       Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            }
        }
    }
}