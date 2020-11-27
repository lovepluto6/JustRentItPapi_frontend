using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace JustRentItPapi.Models
{
    public partial class projectContext : DbContext
    {
        public projectContext()
        {
        }

        public projectContext(DbContextOptions<projectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=database-1.cuqoajagbfwh.us-east-1.rds.amazonaws.com,1433;database=project;User ID=admin;Password=adminadmin;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.Carid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("carid");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("brand");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Engine)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("engine");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.Yearmade)
                    .HasColumnType("date")
                    .HasColumnName("yearmade");
            });

            modelBuilder.Entity<Rent>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Confirmation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("confirmation");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Rentperiod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("rentperiod");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Userid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("userid");

                entity.Property(e => e.Joiningdate)
                    .HasColumnType("date")
                    .HasColumnName("joiningdate");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
