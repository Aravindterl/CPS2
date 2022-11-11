using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CPS2.Models;

public partial class CpsContext : DbContext
{
    public CpsContext()
    {
    }

    public CpsContext(DbContextOptions<CpsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cp> Cps { get; set; }

    public virtual DbSet<Ecfsetup> Ecfsetups { get; set; }

    public virtual DbSet<Fxr> Fxrs { get; set; }

    public virtual DbSet<Holidaycalendersetup> Holidaycalendersetups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CPS;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cps__3214EC0761060776");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Customticker).HasColumnName("customticker");
            entity.Property(e => e.Fameticker).HasColumnName("fameticker");
            entity.Property(e => e.Holidaycalender).HasColumnName("holidaycalender");
            entity.Property(e => e.Inputgranularity).HasColumnName("inputgranularity");
            entity.Property(e => e.Inputunit).HasColumnName("inputunit");
            entity.Property(e => e.Maxprice)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("maxprice");
            entity.Property(e => e.Minprice)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("minprice");
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Modifieddate)
                .HasColumnType("datetime")
                .HasColumnName("modifieddate");
            entity.Property(e => e.Platt).HasColumnName("platt");
            entity.Property(e => e.Priceseriesname).HasColumnName("priceseriesname");
        });

        modelBuilder.Entity<Ecfsetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ecfsetup__3214EC07BCEFF169");

            entity.ToTable("Ecfsetup");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Energyconversioname).HasColumnName("energyconversioname");
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Modifieddate)
                .HasColumnType("datetime")
                .HasColumnName("modifieddate");
            entity.Property(e => e.Startdate)
                .HasColumnType("date")
                .HasColumnName("startdate");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Fxr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fxrs__3214EC07DC5058F7");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fameticker).HasColumnName("fameticker");
            entity.Property(e => e.Fxrateseriesname).HasColumnName("fxrateseriesname");
            entity.Property(e => e.Holidaycalender).HasColumnName("holidaycalender");
            entity.Property(e => e.Inputgranularity).HasColumnName("inputgranularity");
            entity.Property(e => e.Maxprice)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("maxprice");
            entity.Property(e => e.Minprice)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("minprice");
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Modifieddate)
                .HasColumnType("datetime")
                .HasColumnName("modifieddate");
        });

        modelBuilder.Entity<Holidaycalendersetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Holidayc__3214EC077E3701DB");

            entity.ToTable("Holidaycalendersetup");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Dates)
                .HasColumnType("date")
                .HasColumnName("dates");
            entity.Property(e => e.Excludewee)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("excludewee");
            entity.Property(e => e.Holidayname).HasColumnName("holidayname");
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Modifieddate)
                .HasColumnType("datetime")
                .HasColumnName("modifieddate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
