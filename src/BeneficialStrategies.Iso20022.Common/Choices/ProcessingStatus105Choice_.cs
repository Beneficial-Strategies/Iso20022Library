// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProcessingStatus105Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("_u6b1IaodEfCG2_q2WT-90w")]
    [DisplayName("Processing Status 105 Choice")]
    [KnownType(typeof(ProcessingStatus105Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus105Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus105Choice.Repair))]
    [KnownType(typeof(ProcessingStatus105Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus105Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus105Choice.Denied))]
    [KnownType(typeof(ProcessingStatus105Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus105Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus105Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus105Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus105Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus105Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus105Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus105Choice.Cancelled))]
    public abstract record ProcessingStatus105Choice_
    {
    }
}
