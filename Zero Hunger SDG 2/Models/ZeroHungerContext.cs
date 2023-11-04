using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Zero_Hunger_SDG_2.Models
{
    public partial class ZeroHungerContext : DbContext
    {
        public ZeroHungerContext()
        {
        }

        public ZeroHungerContext(DbContextOptions<ZeroHungerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Crop> Crops { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DB"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crop>(entity =>
            {
                entity.ToTable("crops");

                entity.Property(e => e.CropId)
                    .ValueGeneratedNever()
                    .HasColumnName("CropID");

                entity.Property(e => e.CropExpenses).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CropIncome).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CropName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
