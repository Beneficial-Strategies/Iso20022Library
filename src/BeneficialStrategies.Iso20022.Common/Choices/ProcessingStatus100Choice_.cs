// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProcessingStatus100Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("_XVfSEY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("Processing Status 100 Choice")]
    [KnownType(typeof(ProcessingStatus100Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus100Choice.Repair))]
    [KnownType(typeof(ProcessingStatus100Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus100Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus100Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus100Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus100Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus100Choice.Proprietary))]
    public abstract record ProcessingStatus100Choice_
    {
    }
}
