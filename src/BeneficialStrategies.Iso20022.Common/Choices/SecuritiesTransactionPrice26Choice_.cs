// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice26Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice to define the price of the securities transaction.</summary>
    [IsoId("_HTGlQa2kEfCfRtNoJv1jFQ")]
    [DisplayName("Securities Transaction Price 26 Choice")]
    [KnownType(typeof(SecuritiesTransactionPrice26Choice.MonetaryValue))]
    [KnownType(typeof(SecuritiesTransactionPrice26Choice.Percentage))]
    [KnownType(typeof(SecuritiesTransactionPrice26Choice.Yield))]
    [KnownType(typeof(SecuritiesTransactionPrice26Choice.BasisPoints))]
    [KnownType(typeof(SecuritiesTransactionPrice26Choice.NoPrice))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice26Choice.MonetaryValue))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice26Choice.Percentage))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice26Choice.Yield))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice26Choice.BasisPoints))]
    [JsonDerivedType(typeof(SecuritiesTransactionPrice26Choice.NoPrice))]
    public abstract record SecuritiesTransactionPrice26Choice_
    {
    }
}
