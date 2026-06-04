// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementMethod7Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Settlement details to determine whether payment is a credit or debit.</summary>
    [IsoId("_GT04AXeKEfCdoODv2ypKfw")]
    [DisplayName("Settlement Method 7 Choice")]
    [KnownType(typeof(SettlementMethod7Choice.Credit))]
    [KnownType(typeof(SettlementMethod7Choice.Debit))]
    [JsonDerivedType(typeof(SettlementMethod7Choice.Credit))]
    [JsonDerivedType(typeof(SettlementMethod7Choice.Debit))]
    public abstract record SettlementMethod7Choice_
    {
    }
}
