using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ExercicioADO1
{
    public class ProdutosDb
    {
        public DataTable CategoriasLista()
        {
            string sql = @"SELECT CategoryId, CategoryName
                           FROM Categories";

            var da = new SqlDataAdapter(sql, Northwind.Conexao);
            var tb = new DataTable();

            da.Fill(tb);

            return tb;

        }

        public DataTable ProdutosPorCategoria(int categoriaId)
        {
            string sql = @"SELECT ProductName,
                           UnitPrice, 
                           UnitsInStock
                           FROM Products
                           WHERE CategoryId = @CategoryId";

            var da = new SqlDataAdapter(sql, Northwind.Conexao);
            da.SelectCommand
               .Parameters
               .AddWithValue("@CategoryId", categoriaId);

            var tb = new DataTable();

            da.Fill(tb);

            return tb;
        }

        public DataTable FornecedoresLista()
        {
            string sql = @"SELECT SupplierId, CompanyName
                           FROM Suppliers";

            var da = new SqlDataAdapter(sql, Northwind.Conexao);
            var tb = new DataTable();

            da.Fill(tb);

            return tb;
        }

        public DataTable ProdutosPorFornecedor(int supplierId)
        {
            string sql = @"SELECT ProductName,
                           UnitPrice, 
                           UnitsInStock
                           FROM Products
                           WHERE SupplierID = @SupplierId";

            var da = new SqlDataAdapter(sql, Northwind.Conexao);
            da.SelectCommand
               .Parameters
               .AddWithValue("@SupplierId", supplierId);

            var tb = new DataTable();

            da.Fill(tb);

            return tb;
        }
    }
}