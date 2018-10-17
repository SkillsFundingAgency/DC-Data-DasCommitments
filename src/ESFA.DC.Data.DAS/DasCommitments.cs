using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESFA.DC.Data.DAS.Model
{
    public partial class DasCommitments
    {
        public long CommitmentId { get; set; }
        [StringLength(25)]
        public string VersionId { get; set; }
        public long Uln { get; set; }
        public long Ukprn { get; set; }
        public long AccountId { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal AgreedCost { get; set; }
        public long? StandardCode { get; set; }
        public int? ProgrammeType { get; set; }
        public int? FrameworkCode { get; set; }
        public int? PathwayCode { get; set; }
        public int PaymentStatus { get; set; }
        [Required]
        [StringLength(50)]
        public string PaymentStatusDescription { get; set; }
        public int Priority { get; set; }
        [Column(TypeName = "date")]
        public DateTime EffectiveFromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EffectiveToDate { get; set; }
        [StringLength(100)]
        public string LegalEntityName { get; set; }
        public long? TransferSendingEmployerAccountId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferApprovalDate { get; set; }
        public DateTime? PausedOnDate { get; set; }
        public DateTime? WithdrawnOnDate { get; set; }
        [StringLength(6)]
        public string AccountLegalEntityPublicHashedId { get; set; }
    }
}
