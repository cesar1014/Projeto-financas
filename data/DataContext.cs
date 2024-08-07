﻿using Financas.models;
using Financas.models.Financas.models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
     //optionsBuilder.UseSqlServer("Server=LAPTOP-MPBBGBHD\\SQLEXPRESS;Database=Financas;Trusted_Connection=True;TrustServerCertificate=True;"); // PC LUCAS

        //optionsBuilder.UseSqlServer(@"Server=localhost;Database=Financas;Trusted_Connection=True;TrustServerCertificate=True;"); // PC GABRIEL
     optionsBuilder.UseSqlServer("Server=localhost\\SQLSERVER2014ECE;Database=financas;Trusted_Connection=True;TrustServerCertificate=True");// facul
    }

    public DbSet<Categorias> Categorias { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Transacoes> Transacoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transacoes>()
            .HasOne(t => t.categoria)
            .WithMany()
            .HasForeignKey(t => t.CategoriaID);

        Seed(modelBuilder);
    }

    private void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorias>().HasData(
            new Categorias { ID = 1, descricao = "Alimentação", tipo = "Saída" },
            new Categorias { ID = 2, descricao = "Transporte", tipo = "Saída" },
            new Categorias { ID = 3, descricao = "Educação", tipo = "Saída" },
            new Categorias { ID = 4, descricao = "Transporte", tipo = "Saída" },
            new Categorias { ID = 5, descricao = "Educação", tipo = "Saída" },
            new Categorias { ID = 6, descricao = "Lazer", tipo = "Saída" },
            new Categorias { ID = 7, descricao = "Cuidados Pessoais", tipo = "Saída" },
            new Categorias { ID = 8, descricao = "Investimento", tipo = "Saída" },
            new Categorias { ID = 9, descricao = "Impostos", tipo = "Saída" },
            new Categorias { ID = 10, descricao = "Saúde", tipo = "Saída" },
            new Categorias { ID = 11, descricao = "Outras despesas", tipo = "Saída" },
            new Categorias { ID = 12, descricao = "Salário", tipo = "Entrada" },
            new Categorias { ID = 13, descricao = "Dividendos", tipo = "Entrada" },
            new Categorias { ID = 14, descricao = "13° Salário", tipo = "Entrada" },
            new Categorias { ID = 15, descricao = "Alugueis", tipo = "Entrada" }
        );
    }
}
