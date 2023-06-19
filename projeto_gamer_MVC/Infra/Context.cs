
using Microsoft.EntityFrameworkCore;
using projeto_gamer_MVC.Models;

namespace projeto_gamer_MVC.Infra
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {   
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // String de conexão com o banco
                // Data source = O nome do servidor do gerenciado do banco
                // Initial Catalog = Nome do banco de dados
                // Integrated Security = Autentificação pelo windows
                // TrustServerCertificate = Autentificação pelo windows

                // Autentificação pelo sqlServer 
                // user Id = "Seu login"
                // pwd = "Sua senha"
                optionsBuilder.UseSqlServer("Data Source = NOTE02-S15; initial catalog = MVCGamer; user Id = sa; pwd = Senai@134; TrustServerCertificate = true");
            }
        }

        public DbSet<Jogador> Jogador {get; set;}
        public DbSet<Equipe> Equipe {get; set;}

    }
}