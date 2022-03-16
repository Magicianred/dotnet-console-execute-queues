using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Magicianred.ExecuteQueue.Log.DAL.Ef.MySql.EfModels
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QueueLog> QueueLogs { get; set; }
        public virtual DbSet<QueueLogItem> QueueLogItems { get; set; }
        public virtual DbSet<QueueLogType> QueueLogTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=127.0.0.1;Database=my-blog;Uid=root;Pwd=rootroot;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QueueLog>(entity =>
            {
                entity.ToTable("queue_logs");

                entity.HasIndex(e => e.QueueId, "fk_queue_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.QueueId).HasColumnName("queue_id");
            });

            modelBuilder.Entity<QueueLogItem>(entity =>
            {
                entity.ToTable("queue_log_items");

                entity.HasIndex(e => e.LogId, "fk_log_queue_idx");

                entity.HasIndex(e => e.LogTypeId, "fk_log_type_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.LogTypeId).HasColumnName("log_type_id");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .HasColumnName("message");

                entity.HasOne(d => d.LogType)
                    .WithMany(p => p.QueueLogItems)
                    .HasForeignKey(d => d.LogTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_log_queue_type");
            });

            modelBuilder.Entity<QueueLogType>(entity =>
            {
                entity.ToTable("queue_log_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
