// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat10Choice.Balance))]
    [KnownType(typeof(BalanceFormat10Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat10Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat10Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat10Choice.PartWayPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat10Choice.Balance), nameof(BalanceFormat10Choice.Balance))]
    [JsonDerivedType(
        typeof(BalanceFormat10Choice.EligibleBalance),
        nameof(BalanceFormat10Choice.EligibleBalance)
    )]
    [JsonDerivedType(
        typeof(BalanceFormat10Choice.NotEligibleBalance),
        nameof(BalanceFormat10Choice.NotEligibleBalance)
    )]
    [JsonDerivedType(
        typeof(BalanceFormat10Choice.FullPeriodUnits),
        nameof(BalanceFormat10Choice.FullPeriodUnits)
    )]
    [JsonDerivedType(
        typeof(BalanceFormat10Choice.PartWayPeriodUnits),
        nameof(BalanceFormat10Choice.PartWayPeriodUnits)
    )]
    [IsoId("_cjzu3ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Balance Format 10 Choice")]
    public abstract record BalanceFormat10Choice_ { }
}
