using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parqueadero2.Models;

public partial class DbParqueaderoContext : DbContext
{
    public DbParqueaderoContext()
    {
    }

    public DbParqueaderoContext(DbContextOptions<DbParqueaderoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbUsuario> TbUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder != null)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            // => optionsBuilder.UseSqlServer("server=DESKTOP-91MHGOO\\SQLEXPRESS; database=DB_PARQUEADERO; integrated security=true;TrustServerCertificate=Yes");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_USUAR__3214EC2759DB2BE5");

            entity.ToTable("TB_USUARIOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NumeroDePlaca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DE_PLACA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
