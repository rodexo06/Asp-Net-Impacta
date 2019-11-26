using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExercicioServico.Models
{
    public class AwDb
    {
        #region SQL - EXPRESSÕES


        private const string sqlListaPaises = @"
        SELECT Pais.Name AS Pais
        FROM Person.Person AS pessoa
            INNER JOIN Person.BusinessEntityAddress AS enderecos ON enderecos.BusinessEntityID = pessoa.BusinessEntityID
            INNER JOIN Person.Address AS endereco ON endereco.AddressID = enderecos.AddressID
            INNER JOIN Person.StateProvince AS estado ON estado.StateProvinceID = endereco.StateProvinceID
            INNER JOIN Person.CountryRegion AS Pais ON Pais.CountryRegionCode = estado.CountryRegionCode
        GROUP BY Pais.Name";

        #endregion





        #region Database-helper

        //
        // Retorna a string de conexao
        //
        private static string conexao =
        @"  Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Adventure;Integrated Security=True;
        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                                                       MultiSubnetFailover=False";

        // Retorna um objeto DbCommand com a conexão,
        // expressão SQL e Parâmetros preenchidos
        private static DbCommand ObterCommand(string sql, params object[] parametros)
        {
            var cn = new SqlConnection(conexao);
            var cmd = new SqlCommand
            {
                CommandText = sql,
                Connection = cn
            };
            if (parametros.Length > 0)
            {
                for (int i = 0; i < parametros.Length; i += 2)
                {
                    cmd.Parameters.AddWithValue(
                    parametros[i].ToString(),
                    parametros[i + 1]);
                }
            }
            return cmd;
        }
        // Obter Data Reder
        // Retorna uma instância de um DataReader
        private static DbDataReader ObterDataReader(DbCommand cmd)
        {
            cmd.Connection.Open();
            var reader = cmd.ExecuteReader(
            CommandBehavior.CloseConnection);
            return reader;
        }

        #endregion
    }
}