using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioEntityFramework
{
    public class ProdutoDb
    {
        public List<Categoria> CategoriaLista()
        {
            using ( var db = new NorthwindContext())
            {
                return db.Categorias.ToList();
            }
        }

        public List<Produto> ProdutoPorCategoria(int categoriaId)
        {
            using (var db = new NorthwindContext())
            {
                var query = from c in db.Produtos
                            where c.CategoriaId == categoriaId
                            select c;
                var lista = query.ToList();
                return lista;
            }
        }

        public List<Fornecedor> FornecedoresLista()
        {
            using (var db = new NorthwindContext())
            {
                return db.Fornecedores.ToList();
            }
        }

        public List<Produto> ProdutosPorFornecedor(int fornecedorId)
        {
            using (var db = new NorthwindContext())
            {
                var query = from c in db.Produtos
                            where c.FornecedorId == fornecedorId
                            select c;
                var lista = query.ToList();
                return lista;
            }
        }

    }
}