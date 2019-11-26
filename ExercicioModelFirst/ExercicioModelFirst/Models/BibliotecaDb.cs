using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioModelFirst.Models
{
    public class BibliotecaDb
    {
        //
        // EditorasLista
        // Retorna a lista de todas as editoras
        //
        public static List<Editoras> EditorasLista()
        {
            using (var db = new pubsEntities())
            {
                return db.Editoras.ToList();
            }
        }

        public static List<Livros> LivrosLista()
        {
            using (var db = new pubsEntities())
            {
                return db.Livros.ToList();
            }
        }

        public static List<Livros> LivrosPorEditora(string editoraId)
        {
            using (var db = new pubsEntities())
            {
                return (from l in db.Livros
                        where l.EditoraId == editoraId
                        select l).ToList();
            }
        }

        public static Editoras   EditoraPorId(string editoraId)
        {
            using (var db = new pubsEntities())
            {
                var editora = (from c in db.Editoras
                               where c.EditoraId == editoraId
                               select c).FirstOrDefault();
                return editora;
            }
        }

        public static List<Autores> AutoresLista()
        {
            using (var db = new pubsEntities())
            {
                return db.Autores.ToList();
            }
        }

        public static Autores AutorPorId(string autorId)
        {
            using (var db = new pubsEntities())
            {
                var autor = (from a in db.Autores
                             where a.AutorId == autorId
                             select a).FirstOrDefault();

                return autor;
            }
        }

        public static List<Livros> LivrosPorAutor(string autorId)
        {
            using (var db = new pubsEntities())
            {
                var livrosAutor = (from a in db.LivroAutores
                                   where a.AutorId.Equals(autorId)
                                   select a.LivroId).ToArray();
                var livros = from l in db.Livros
                             where livrosAutor
                             .Contains(l.LivroId)
                             select l;

                return livros.ToList();
            }
        }
    }

    public partial class Autores
    {
        public string NomeCompleto
        {
            get { return Nome + " " + Sobrenome; }
        }
    }
}