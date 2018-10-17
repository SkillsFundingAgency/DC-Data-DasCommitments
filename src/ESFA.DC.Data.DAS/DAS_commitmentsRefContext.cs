using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ESFA.DC.Data.DAS.Model
{
    public partial class DAS_commitmentsRefContext : DbContext
    {
        public DAS_commitmentsRefContext()
        {
        }

        public DAS_commitmentsRefContext(DbContextOptions<DAS_commitmentsRefContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DasCommitments> DasCommitments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DasCommitments>(entity =>
            {
                entity.HasKey(e => new { e.CommitmentId, e.VersionId });

                entity.HasIndex(e => e.Uln);

                entity.Property(e => e.VersionId).IsUnicode(false);

                entity.Property(e => e.AccountLegalEntityPublicHashedId).IsUnicode(false);

                entity.Property(e => e.PaymentStatusDescription).IsUnicode(false);
            });
        }
    }
}
