using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebPsiquiatricoMVC.Models;

public partial class LabPsiquiatricoContext : DbContext
{
    public LabPsiquiatricoContext()
    {
    }

    public LabPsiquiatricoContext(DbContextOptions<LabPsiquiatricoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Citum> Cita { get; set; }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Personal> Personals { get; set; }

    public virtual DbSet<Recetum> Receta { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LabPsiquiatrico;User ID=usrpsiquiatrico;Password=123456");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Citum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cita__3213E83F6C87DA4C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaReservacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaReservacion");
            entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");
            entity.Property(e => e.Motivo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("motivo");
            entity.Property(e => e.Pago)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pago");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Cita_Paciente");
        });

        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Medicame__3213E83F842465AF");

            entity.ToTable("Medicamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dosificacion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("dosificacion");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdReceta).HasColumnName("idReceta");
            entity.Property(e => e.NombreMedicamento)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombreMedicamento");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precio");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdRecetaNavigation).WithMany(p => p.Medicamentos)
                .HasForeignKey(d => d.IdReceta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Medicamento_Receta");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paciente__3213E83F659326BE");

            entity.ToTable("Paciente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CedulaIdentidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cedulaIdentidad");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaAdmision)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fechaAdmision");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.HistorialMedico)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("historialMedico");
            entity.Property(e => e.IdPersonal).HasColumnName("idPersonal");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Paciente_Personal");
        });

        modelBuilder.Entity<Personal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personal__3213E83F3D382382");

            entity.ToTable("Personal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CedulaIdentidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cedulaIdentidad");
            entity.Property(e => e.Especialidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("especialidad");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.HorarioTrabajo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("horarioTrabajo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Recetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Receta__3213E83F6EB8AA9E");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CantidadPrescrita)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("cantidadPrescrita");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaReceta)
                .HasColumnType("date")
                .HasColumnName("fechaReceta");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");
            entity.Property(e => e.InstruccionesUso)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("instruccionesUso");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Receta)
                .HasForeignKey(d => d.IdPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Receta_Paciente");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F8E1B4B6B");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdPersonal).HasColumnName("idPersonal");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Usuario_Personal");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
