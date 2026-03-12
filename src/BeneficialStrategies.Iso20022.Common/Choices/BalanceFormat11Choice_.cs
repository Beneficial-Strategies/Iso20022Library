// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat11Choice.Balance))]
    [KnownType(typeof(BalanceFormat11Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat11Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat11Choice.Balance),nameof(BalanceFormat11Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat11Choice.EligibleBalance),nameof(BalanceFormat11Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat11Choice.NotEligibleBalance),nameof(BalanceFormat11Choice.NotEligibleBalance))]
    [IsoId("_JBUKmxuyEeyhRdHRjakS2w")]
    [DisplayName("Balance Format 11 Choice")]
    public abstract partial record BalanceFormat11Choice_
    {
    }
}
