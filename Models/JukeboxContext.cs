using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JukeboxApp.Models
{
    public partial class JukeboxContext : DbContext
    {
        public JukeboxContext()
        {
        }

        public JukeboxContext(DbContextOptions<JukeboxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoverPages> CoverPages { get; set; }
        public virtual DbSet<Tracks> Tracks { get; set; }
        public virtual DbSet<TracksAlbum> TracksAlbum { get; set; }
        public virtual DbSet<TracksLists> TracksLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MX-IT05058;Initial Catalog=Jukebox;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoverPages>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tracks>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Artist)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<TracksAlbum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdListNavigation)
                    .WithMany(p => p.TracksAlbum)
                    .HasForeignKey(d => d.IdList)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TracksAlbum_TracksLists");

                entity.HasOne(d => d.IdTrackNavigation)
                    .WithMany(p => p.TracksAlbum)
                    .HasForeignKey(d => d.IdTrack)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TracksAlbum_TracksAlbum");
            });

            modelBuilder.Entity<TracksLists>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
