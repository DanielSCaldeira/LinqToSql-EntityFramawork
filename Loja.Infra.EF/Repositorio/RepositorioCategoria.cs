using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Infra.EF.Repositorio
{
    public class RepositorioCategoria
    {
        public void AdicionarCategoria(string nome)
        {
            Categoria categoria = new Categoria();
            categoria.Nome = nome;

            LojaEFEntities ef = new LojaEFEntities();
            ef.Categoria.Add(categoria);
            ef.SaveChanges();
        }       
        
        public void AlterarCategoria(int id ,string nome)
        {

            LojaEFEntities ef = new LojaEFEntities();
            var categoria = ef.Categoria.First(x => x.Id == id);
            categoria.Nome = nome;
            ef.SaveChanges();
        }
    }
}
