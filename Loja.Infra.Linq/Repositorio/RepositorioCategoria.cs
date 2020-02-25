﻿using System;
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
    }
}