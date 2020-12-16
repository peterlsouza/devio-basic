using System;
using System.Collections.Generic;
using System.Text;
using AppMVCBasic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMVCBasic.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //para criar as tabelas no banco com base nas models indicadas..
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        /* Criamos as entidades e setamos todas as propriedades
         * Colocamos os Data Annotations nas models, para que as tabelas sejam criadas com os tipos corretos.
         * ajustar nome da DB em appsettings
         * Add-Migration TabelasSistema para criar a migration.. arq salvo na pasta data/Migrations
         * 
         */

    }
}
    