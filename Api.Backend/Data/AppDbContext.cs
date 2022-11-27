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

            builder.Entity<Produto_Campanha>()
                .HasOne(Produto_Campanha => Produto_Campanha.Produto)
                .WithMany(Produto => Produto.Produto_Campanhas)
                .HasForeignKey(Produto_Campanha => Produto_Campanha.ProdutoId);

            builder.Entity<Produto_Campanha>()
                .HasOne(Produto_Campanha => Produto_Campanha.Campanha)
                .WithMany(Campanha => Campanha.Produto_Campanhas)
                .HasForeignKey(Produto_Campanha => Produto_Campanha.CampanhaId);


        }
        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Instituicao> Instituicaos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Maladireta> Maladiretas { get; set; }
        public DbSet<Produto_Campanha> Produto_Campanhas { get; set; }

    }
}
