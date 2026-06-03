// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason78Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the pending reason.</summary>
    [IsoId("adc59131-17e4-45bb-97b8-f42af1ccff9b")]
    [DisplayName("Pending Reason 78 Choice")]
    [KnownType(typeof(PendingReason78Choice.Code))]
    [KnownType(typeof(PendingReason78Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason78Choice.Code))]
    [JsonDerivedType(typeof(PendingReason78Choice.Proprietary))]
    public abstract record PendingReason78Choice_
    {
    }
}
