using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeGerenc.DAL.DBContext;

public partial class CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext : DbContext
{
    public CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext()
    {
    }

    public CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext(DbContextOptions<CUsersMarceSourceReposLp3SistemadegerenciamentodefinancasSistemadegerencSistemadegerencDalDbDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Despesa> Despesas { get; set; }

    public virtual DbSet<Receitum> Receita { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\marce\\source\\repos\\Lp3-SistemaDeGerenciamentoDeFinancas\\SistemaDeGerenc\\SistemaDeGerenc.DAL\\db\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Despesa>(entity =>
        {
            entity.HasKey(e => e.IdDespesa).HasName("PK__DESPESA__908A38B4C0643DCA");

            entity.ToTable("DESPESA");

            entity.Property(e => e.IdDespesa).HasColumnName("Id_despesa");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.Data)
                .HasColumnType("date")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Receitum>(entity =>
        {
            entity.HasKey(e => e.IdReceita).HasName("PK__RECEITA__615A29060C72F6BA");

            entity.ToTable("RECEITA");

            entity.Property(e => e.IdReceita).HasColumnName("Id_receita");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.Data)
                .HasColumnType("date")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIO__EF59F76267167FC0");

            entity.ToTable("USUARIO");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("senha");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
