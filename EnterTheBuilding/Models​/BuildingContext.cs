using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EnterTheBuilding.Models​
{
    public partial class BuildingContext : DbContext
    {
        public BuildingContext()
        {
        }

        public BuildingContext(DbContextOptions<BuildingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblEntryoff> TblEntryoffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Building;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblEntryoff>(entity =>
            {
                entity.ToTable("tbl_Entryoff");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Covid)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CurDate).HasColumnType("datetime");

                entity.Property(e => e.Loc)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
                //entity.Property(e => e.Mobile)
                // .HasMaxLength(100)
                //    .IsFixedLength(true);


                entity.Property(e => e.Temp).HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
