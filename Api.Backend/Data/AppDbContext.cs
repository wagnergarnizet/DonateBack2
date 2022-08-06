using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Estoque>()
                .HasOne(estoque => estoque.Campanha)
                .WithMany(campanha => campanha.Estoques)
                .HasForeignKey(estoque => estoque.CampanhaId);

            builder.Entity<Estoque>()
                .HasOne(estoque => estoque.Produto)
                .WithMany(produto => produto.Estoques)
                .HasForeignKey(estoque => estoque.ProdutoId);

            builder.Entity<Campanha>()
                .HasOne(campanha => campanha.Instituicao)
                .WithMany(instituicao => instituicao.Campanhas)
                .HasForeignKey(campanha => campanha.InstituicaoId);

            builder.Entity<Maladireta>()
                .HasOne(campanha => campanha.Instituicao)
                .WithMany(maladireta => maladireta.Maladiretas)
                .HasForeignKey(campanha => campanha.InstituicaoId);

            builder.Entity<Instituicao>()
                .HasOne(instituicao => instituicao.Usuario)
                .WithMany(usuario => usuario.Instituicaos)
                .HasForeignKey(instituicao => instituicao.UsuarioId);


            builder.Entity<Produto>()
                .HasOne(produto => produto.Categoria)
                .WithMany(categoria => categoria.Produtos)
                .HasForeignKey(produto => produto.CategoriaId);
        }
        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Instituicao> Instituicaos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Maladireta> Maladiretas { get; set; }

    }
}
