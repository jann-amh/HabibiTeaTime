using HabibiTeaTime.Properties;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HabibiTeaTime.Database.Models
{
    public partial class HabibiteatimeContext : DbContext
    {
        public HabibiteatimeContext()
        {
        }

        public HabibiteatimeContext(DbContextOptions<HabibiteatimeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bot> Bots { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(Resources.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bot>(entity =>
            {
                entity.ToTable("bot");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Channels)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Token)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("messages");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Channel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Message1)
                    .HasMaxLength(2500)
                    .HasColumnName("Message")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Time).HasColumnType("bigint(20)");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
