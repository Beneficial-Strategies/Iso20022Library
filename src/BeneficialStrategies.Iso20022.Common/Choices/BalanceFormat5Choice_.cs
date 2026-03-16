// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat5Choice.Balance))]
    [KnownType(typeof(BalanceFormat5Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat5Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat5Choice.Balance), nameof(BalanceFormat5Choice.Balance))]
    [JsonDerivedType(
        typeof(BalanceFormat5Choice.EligibleBalance),
        nameof(BalanceFormat5Choice.EligibleBalance)
    )]
    [JsonDerivedType(
        typeof(BalanceFormat5Choice.NotEligibleBalance),
        nameof(BalanceFormat5Choice.NotEligibleBalance)
    )]
    [IsoId("_kiYcATq5EeWQ1Y7f8kds2A")]
    [DisplayName("Balance Format 5 Choice")]
    public abstract record BalanceFormat5Choice_ { }
}
