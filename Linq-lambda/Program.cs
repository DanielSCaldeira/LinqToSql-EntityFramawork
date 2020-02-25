namespace Linq_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Salvando com entity framework
            //new Loja.Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria("Frutas");
            //new Loja.Infra.EF.Repositorio.RepositorioCategoria().AdicionarCategoria("Eletronicos");

            // Salvando com linq to Sql
            new Loja.Infra.Linq.Repositorio.RepositorioCategoria().AdicionarCategoria("Roupas");
            new Loja.Infra.Linq.Repositorio.RepositorioCategoria().AdicionarCategoria("Carnes");
        }
    }
}
