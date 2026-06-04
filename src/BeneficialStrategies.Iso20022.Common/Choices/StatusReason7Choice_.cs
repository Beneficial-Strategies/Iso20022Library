// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.StatusReason7Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code and proprietary format for a collateral status reason.</summary>
    [IsoId("_nLSClKkxEeynsLtPxJMJTQ")]
    [DisplayName("Status Reason 7 Choice")]
    [KnownType(typeof(StatusReason7Choice.Code))]
    [KnownType(typeof(StatusReason7Choice.Proprietary))]
    [JsonDerivedType(typeof(StatusReason7Choice.Code))]
    [JsonDerivedType(typeof(StatusReason7Choice.Proprietary))]
    public abstract record StatusReason7Choice_
    {
    }
}
