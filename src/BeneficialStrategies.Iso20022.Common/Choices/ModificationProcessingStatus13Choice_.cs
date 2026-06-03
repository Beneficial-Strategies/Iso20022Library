// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ModificationProcessingStatus13Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("89fa57e3-c398-4f59-ab4a-1a43d0a2d3dd")]
    [DisplayName("Modification Processing Status 13 Choice")]
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
    public abstract record ModificationProcessingStatus13Choice_;
}
