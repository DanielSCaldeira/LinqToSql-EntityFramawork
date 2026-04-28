# Linq-lambda: Comparativo Entity Framework vs Linq to SQL

Este projeto demonstra, de forma prática, as diferenças de uso entre Entity Framework (EF) e Linq to SQL para operações básicas de CRUD em um contexto de loja, utilizando C# e .NET Framework 4.7.2.

## Estrutura do Projeto

- **Linq-lambda/**: Projeto principal (console) que executa exemplos de uso dos repositórios.
- **Loja.Infra.EF/**: Implementação de acesso a dados usando Entity Framework 6.
- **Loja.Infra.Linq/**: Implementação de acesso a dados usando Linq to SQL.

## Funcionalidades Demonstradas

- Adicionar, alterar e excluir categorias
- Listar produtos
- Comparação direta entre as duas abordagens (EF e Linq to SQL)

## Como Executar

1. **Pré-requisitos:**
   - .NET Framework 4.7.2
   - SQL Server (ajuste a string de conexão em `App.config` se necessário)
2. **Restaure os pacotes NuGet:**
   - EntityFramework 6.4.0
   - Newtonsoft.Json 12.0.3
3. **Compile a solução**
4. **Execute o projeto `Linq-lambda`**

## Exemplo de Uso

O `Program.cs` executa:
- Listagem de produtos usando Entity Framework
- Listagem de produtos usando Linq to SQL

```csharp
// ...
var produtosEF = new Loja.Infra.EF.Repositorio.RepositorioCategoria().ListarProdutos();
// ...
var produtosLinq = new Loja.Infra.Linq.Repositorio.RepositorioCategoria().ListarProdutos();
// ...
```

## Configuração de Banco de Dados

- O banco de dados utilizado é `Loja`.
- As strings de conexão estão em `Linq-lambda/App.config`.
- Usuário padrão: `sa`, senha: `123` (altere conforme sua configuração local).

## Estrutura das Entidades

- **Categoria**: Id, Nome
- **Produto**: Id, IdCategoria, Nome, Valor

## Observações

- O projeto é didático e visa demonstrar diferenças de implementação, não sendo recomendado para produção.
- O código das entidades é gerado automaticamente pelos designers do Visual Studio (EDMX/DBML).

## Licença

MIT
