using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;

namespace HomeDashboardQueries.Models
{
    public partial class homeContext : DbContext
    {
        public homeContext()
        {
        }

        public homeContext(DbContextOptions<homeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chore> Chores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["home"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chore>(entity =>
            {
                entity.ToTable("chores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Chore1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chore");

                entity.Property(e => e.ChoreTime).HasColumnName("choreTime");

                entity.Property(e => e.Friday)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Monday)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Saturday)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sunday)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Thursday)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tuesday)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Wednesday)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
