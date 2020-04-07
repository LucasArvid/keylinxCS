using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CSKeylinx.Models;
using Microsoft.Extensions.Configuration;

namespace CSKeylinx.Data
{
    public partial class CSKeylinxContext : DbContext
    {
        public CSKeylinxContext()
        {
        }

        public CSKeylinxContext(DbContextOptions<CSKeylinxContext> options) : base(options)
        {
        }

        public virtual DbSet<Clans> Clans { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<Players> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clans>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Origin).HasMaxLength(50);
            });

            modelBuilder.Entity<Matches>(entity =>
            {
                entity.Property(e => e.MatchDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClanAway)
                    .WithMany(p => p.MatchesClanAway)
                    .HasForeignKey(d => d.ClanAwayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Matches_ToClansAway");

                entity.HasOne(d => d.ClanHome)
                    .WithMany(p => p.MatchesClanHome)
                    .HasForeignKey(d => d.ClanHomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Matches_ToClansHome");
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Clan)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.ClanId)
                    .HasConstraintName("FK_Player_ToClan");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
