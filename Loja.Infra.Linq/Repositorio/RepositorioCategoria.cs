using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Infra.Linq.Repositorio
{
    public class RepositorioCategoria
    {
        public void AdicionarCategoria(string nome)
        {
            Categoria categoria = new Categoria();
            categoria.Nome = nome;

            LojaLinqToSqlDataContext linq = new LojaLinqToSqlDataContext();
            linq.Categorias.InsertOnSubmit(categoria);
            linq.SubmitChanges();
        }

        public void AlterarCategoria(int id, string nome)
        {
            LojaLinqToSqlDataContext linq = new LojaLinqToSqlDataContext();
            var categoria = linq.Categorias.First(x => x.Id == id);

            categoria.Nome = nome;

            linq.SubmitChanges();
        }   
        
        public void ExcluirCategoria(int id)
        {
            LojaLinqToSqlDataContext linq = new LojaLinqToSqlDataContext();
            var categoria = linq.Categorias.First(x => x.Id == id);
            linq.Categorias.DeleteOnSubmit(categoria);
            linq.SubmitChanges();
        }

        public List<Produto> ListarProdutos()
        {
            LojaLinqToSqlDataContext linq = new LojaLinqToSqlDataContext();
            return linq.Produtos.AsParallel().ToList();
        }

    }
}
