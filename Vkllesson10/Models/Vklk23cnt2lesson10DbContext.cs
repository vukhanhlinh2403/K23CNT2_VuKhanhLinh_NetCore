using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vkllesson10.Models;

public partial class Vklk23cnt2lesson10DbContext : DbContext
{
    public Vklk23cnt2lesson10DbContext()
    {
    }

    public Vklk23cnt2lesson10DbContext(DbContextOptions<Vklk23cnt2lesson10DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VklCategory> VklCategories { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=LAPTOP-C30ND4U3\\MAY1;Database=Vklk23cnt2lesson10Db;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VklCategory>(entity =>
        {
            entity.HasKey(e => e.CateId);

            entity.ToTable("VklCategory");

            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.CateName).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
