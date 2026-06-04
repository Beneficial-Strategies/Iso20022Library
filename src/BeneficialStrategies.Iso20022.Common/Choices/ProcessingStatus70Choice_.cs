// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.ProcessingStatus70Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [IsoId("_mLAX4eGHEeWCAvUNsZ5u6g")]
    [DisplayName("Processing Status 70 Choice")]
    [KnownType(typeof(ProcessingStatus70Choice.Code))]
    [KnownType(typeof(ProcessingStatus70Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus70Choice.Code))]
    [JsonDerivedType(typeof(ProcessingStatus70Choice.Proprietary))]
    public abstract record ProcessingStatus70Choice_
    {
    }
}
