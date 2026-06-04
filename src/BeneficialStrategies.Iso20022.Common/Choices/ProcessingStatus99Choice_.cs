// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProcessingStatus99Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("_XGFkIY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Processing Status 99 Choice")]
    [KnownType(typeof(ProcessingStatus99Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus99Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus99Choice.Repair))]
    [KnownType(typeof(ProcessingStatus99Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus99Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus99Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus99Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus99Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus99Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus99Choice.Proprietary))]
    public abstract record ProcessingStatus99Choice_
    {
    }
}
