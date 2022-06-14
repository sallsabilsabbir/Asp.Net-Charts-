using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Charts.Models;

namespace Charts.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<ChartsTable> ChartsTables { get; set; } = null!;
        public virtual DbSet<Emplyee> Emplyees { get; set; } = null!;
        public virtual DbSet<NewEmployeeJoin> NewEmployeeJoins { get; set; } = null!;
        public virtual DbSet<Onlydatetime> Onlydatetimes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emplyee>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<NewEmployeeJoin>(entity =>
            {
                entity.Property(e => e.Empid).ValueGeneratedNever();

                entity.Property(e => e.Gender).IsFixedLength();
            });

            modelBuilder.Entity<Onlydatetime>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
