// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason82Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.</summary>
    [IsoId("_i1Qv8bMZEfCEXew4g5B5oA")]
    [DisplayName("Pending Reason 82 Choice")]
    [KnownType(typeof(PendingReason82Choice.Code))]
    [KnownType(typeof(PendingReason82Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason82Choice.Code))]
    [JsonDerivedType(typeof(PendingReason82Choice.Proprietary))]
    public abstract record PendingReason82Choice_
    {
    }
}
