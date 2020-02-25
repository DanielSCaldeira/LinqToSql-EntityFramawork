using Newtonsoft.Json;
using System;

namespace Linq_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Salvando com entity framework
            //new Loja.Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria("Frutas");
            //new Loja.Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria("Eletronicos");
            var produtosEF = new Loja.Infra.EF.Repositorio.RepositorioCategoria().ListarProdutos();
            Console.WriteLine("------------Entity framework-----------------");
            foreach (var item in produtosEF)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item.Nome));
            }

            // Salvando com linq to Sql
            // new Loja.Infra.Linq.Repositorio.RepositorioCategoria().AdicionarCategoria("Roupas");
            //new Loja.Infra.Linq.Repositorio.RepositorioCategoria().AdicionarCategoria("Carnes");
            var produtosLinq = new Loja.Infra.Linq.Repositorio.RepositorioCategoria().ListarProdutos();
            Console.WriteLine(" ");
            Console.WriteLine("--------------Linq to Sql---------------------");
            foreach (var item in produtosLinq)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item.Nome));
            }

            Console.ReadKey();
        }
    }
}
