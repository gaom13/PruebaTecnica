using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Domain.Models;

namespace PruebaTecnica.Data.Context;

public partial class LabDevContext : DbContext
{
    public LabDevContext()
    {
    }

    public LabDevContext(DbContextOptions<LabDevContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CatProducto> CatProductos { get; set; }

    public virtual DbSet<CatTipoCliente> CatTipoClientes { get; set; }

    public virtual DbSet<TblCliente> TblClientes { get; set; }

    public virtual DbSet<TblDetallesFactura> TblDetallesFacturas { get; set; }

    public virtual DbSet<TblFactura> TblFacturas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatProducto>(entity =>
        {
            entity.Property(e => e.Ext)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ext");
            entity.Property(e => e.ImagenProducto).HasColumnType("image");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CatTipoCliente>(entity =>
        {
            entity.ToTable("CatTipoCliente");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TipoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCliente>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Rfc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RFC");

            entity.HasOne(d => d.IdTipoClienteNavigation).WithMany(p => p.TblClientes)
                .HasForeignKey(d => d.IdTipoCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TblClientes_CatTipoCliente");
        });

        modelBuilder.Entity<TblDetallesFactura>(entity =>
        {
            entity.ToTable("TblDetallesFactura");

            entity.Property(e => e.Notas)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PrecioUnitarioProducto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SubTotalProducto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.TblDetallesFacturas)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TblDetallesFactura_TblFacturas");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.TblDetallesFacturas)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TblDetallesFactura_CatProductos");
        });

        modelBuilder.Entity<TblFactura>(entity =>
        {
            entity.Property(e => e.FechaEmisionFactura).HasColumnType("datetime");
            entity.Property(e => e.SubTotalFactura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalImpuesto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TblFacturas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TblFacturas_TblClientes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
