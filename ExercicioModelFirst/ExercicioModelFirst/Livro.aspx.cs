using System;
using ExercicioModelFirst.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExercicioModelFirst
{
    public partial class Livro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Livros> listaDeLivros = null;
            string editoraId = Request.QueryString["editoraId"];
            if (!string.IsNullOrEmpty(editoraId))
            {
                listaDeLivros =
                BibliotecaDb.LivrosPorEditora(editoraId);
                var editora = BibliotecaDb.EditoraPorId(editoraId);
                mensagemLabel.Text = " da Editora " +editora.EditoraNome;
            }
            else
            {
                string autorId = Request.QueryString["autorId"];
                if (!string.IsNullOrEmpty(autorId))
                {

                    listaDeLivros = BibliotecaDb.LivrosPorAutor(autorId);
                    var autor = BibliotecaDb.AutorPorId(autorId);
                    mensagemLabel.Text =" do autor " +autor.NomeCompleto;
                }
                else
                {
                    listaDeLivros = BibliotecaDb.LivrosLista();
                }
            }
            livrosGridView.DataSource = listaDeLivros;
            livrosGridView.DataBind();
        }
    }
}