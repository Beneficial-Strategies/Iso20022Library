// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProcessingStatus106Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("_lo87UaogEfCG2_q2WT-90w")]
    [DisplayName("Processing Status 106 Choice")]
    [KnownType(typeof(ProcessingStatus106Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus106Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus106Choice.Completed))]
    [KnownType(typeof(ProcessingStatus106Choice.Denied))]
    [KnownType(typeof(ProcessingStatus106Choice.Pending))]
    [KnownType(typeof(ProcessingStatus106Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus106Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus106Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus106Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus106Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus106Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus106Choice.Proprietary))]
    public abstract record ProcessingStatus106Choice_
    {
    }
}
