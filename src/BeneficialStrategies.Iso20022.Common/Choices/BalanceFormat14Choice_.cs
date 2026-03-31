// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat14Choice.Balance))]
    [KnownType(typeof(BalanceFormat14Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat14Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat14Choice.Balance), nameof(BalanceFormat14Choice.Balance))]
    [JsonDerivedType(
        typeof(BalanceFormat14Choice.EligibleBalance),
        nameof(BalanceFormat14Choice.EligibleBalance)
    )]
    [JsonDerivedType(
        typeof(BalanceFormat14Choice.NotEligibleBalance),
        nameof(BalanceFormat14Choice.NotEligibleBalance)
    )]
    [IsoId("_piui3zi7Eeydid5dcNPKvg")]
    [DisplayName("Balance Format 14 Choice")]
    public abstract record BalanceFormat14Choice_ { }
}
