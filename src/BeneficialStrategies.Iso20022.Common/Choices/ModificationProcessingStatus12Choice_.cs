// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus12Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("_qESBsaohEfCG2_q2WT-90w")]
    [DisplayName("Modification Processing Status 12 Choice")]
    [KnownType(typeof(AcknowledgedAccepted))]
    [JsonDerivedType(typeof(AcknowledgedAccepted), nameof(AcknowledgedAccepted))]
    [KnownType(typeof(PendingProcessing))]
    [JsonDerivedType(typeof(PendingProcessing), nameof(PendingProcessing))]
    [KnownType(typeof(Denied))]
    [JsonDerivedType(typeof(Denied), nameof(Denied))]
    [KnownType(typeof(Rejected))]
    [JsonDerivedType(typeof(Rejected), nameof(Rejected))]
    [KnownType(typeof(Repaired))]
    [JsonDerivedType(typeof(Repaired), nameof(Repaired))]
    [KnownType(typeof(Modified))]
    [JsonDerivedType(typeof(Modified), nameof(Modified))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Proprietary), nameof(Proprietary))]
    public abstract record ModificationProcessingStatus12Choice_;
}
