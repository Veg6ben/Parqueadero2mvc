   public partial class TbUsuario
   {
       public int Id { get; set; }
       public string? Nombre { get; set; }
       public string? Descripcion { get; set; }
       public int? Cantidad { get; set; }
       public decimal? Precio { get; set; }
       public string? NumeroDePlaca { get; set; }
       public string? Modelo { get; set; }
       public string? Color { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_USUAR__3214EC2759DB2BE5");

            entity.ToTable("TB_USUARIOS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PRECIO");
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
        });

        OnModelCreatingPartial(modelBuilder);
    }
   }
   

