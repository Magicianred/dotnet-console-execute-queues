using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Magicianred.ExecuteQueue.Runner.DAL.Ef.MySql.EfModels
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

        public virtual DbSet<Queue> Queues { get; set; }
        public virtual DbSet<QueueAction> QueueActions { get; set; }
        public virtual DbSet<QueueStatus> QueueStatuses { get; set; }
        public virtual DbSet<QueueTarget> QueueTargets { get; set; }
        public virtual DbSet<QueueType> QueueTypes { get; set; }

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
            modelBuilder.Entity<Queue>(entity =>
            {
                entity.ToTable("queues");

                entity.HasIndex(e => e.ActionId, "fk_queue_action_idx");

                entity.HasIndex(e => e.ParentId, "fk_queue_parent_idx");

                entity.HasIndex(e => e.StatusId, "fk_queue_status_idx");

                entity.HasIndex(e => e.TypeId, "fk_queue_type_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionId).HasColumnName("action_id");

                entity.Property(e => e.ExecuteDate)
                    .HasColumnName("execute_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Payload)
                    .HasMaxLength(1000)
                    .HasColumnName("payload");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.Queues)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_queue_action");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fk_queue_parent");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Queues)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_queue_status");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Queues)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_queue_type");
            });

            modelBuilder.Entity<QueueAction>(entity =>
            {
                entity.ToTable("queue_actions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<QueueStatus>(entity =>
            {
                entity.ToTable("queue_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<QueueTarget>(entity =>
            {
                entity.ToTable("queue_targets");

                entity.HasIndex(e => e.QueueId, "fk_target_queue_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.EntityTypeId).HasColumnName("entity_type_id");

                entity.Property(e => e.ExecuteDate)
                    .HasColumnName("execute_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.QueueId).HasColumnName("queue_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Queue)
                    .WithMany(p => p.QueueTargets)
                    .HasForeignKey(d => d.QueueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_target_queue");
            });

            modelBuilder.Entity<QueueType>(entity =>
            {
                entity.ToTable("queue_types");

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
