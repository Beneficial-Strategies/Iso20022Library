// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat12Choice.Balance))]
    [KnownType(typeof(BalanceFormat12Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat12Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat12Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat12Choice.PartWayPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat12Choice.Balance), nameof(BalanceFormat12Choice.Balance))]
    [JsonDerivedType(
        typeof(BalanceFormat12Choice.EligibleBalance),
        nameof(BalanceFormat12Choice.EligibleBalance)
    )]
    [JsonDerivedType(
        typeof(BalanceFormat12Choice.NotEligibleBalance),
        nameof(BalanceFormat12Choice.NotEligibleBalance)
    )]
    [JsonDerivedType(
        typeof(BalanceFormat12Choice.FullPeriodUnits),
        nameof(BalanceFormat12Choice.FullPeriodUnits)
    )]
    [JsonDerivedType(
        typeof(BalanceFormat12Choice.PartWayPeriodUnits),
        nameof(BalanceFormat12Choice.PartWayPeriodUnits)
    )]
    [IsoId("_KADDNRuyEeyhRdHRjakS2w")]
    [DisplayName("Balance Format 12 Choice")]
    public abstract record BalanceFormat12Choice_ { }
}
