using System;
using BookingWebAPI.Infrastructure.Models.Reservation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BookingWebAPI.Infrastructure.Data
{
    public partial class BookingContext : DbContext
    {
        public BookingContext()
        {
        }

        public BookingContext(DbContextOptions<BookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvailableDateModel> AvailableDateModels { get; set; }
        public virtual DbSet<BookingModel> BookingModels { get; set; }
        public virtual DbSet<RoomModel> RoomModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-9LJ95CE; Database=Booking; Trusted_Connection=True; User=sa; Password=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AvailableDateModel>(entity =>
            {
                entity.ToTable("AvailableDateModel");

                entity.Property(e => e.CheckIn).HasColumnType("datetime");

                entity.Property(e => e.CheckOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<BookingModel>(entity =>
            {
                entity.ToTable("BookingModel");

                entity.HasOne(d => d.RoomModel)
                    .WithMany(p => p.BookingModels)
                    .HasForeignKey(d => d.RoomModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookingModel_AvailableDateModel");

                entity.HasOne(d => d.RoomModelNavigation)
                    .WithMany(p => p.BookingModels)
                    .HasForeignKey(d => d.RoomModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookingModel_RoomModel");
            });

            modelBuilder.Entity<RoomModel>(entity =>
            {
                entity.ToTable("RoomModel");

                entity.Property(e => e.PriceNight).HasColumnType("decimal(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
