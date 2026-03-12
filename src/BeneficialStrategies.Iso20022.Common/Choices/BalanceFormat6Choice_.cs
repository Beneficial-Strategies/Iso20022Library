// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat6Choice.Balance))]
    [KnownType(typeof(BalanceFormat6Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat6Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat6Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat6Choice.PartWayPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat6Choice.Balance),nameof(BalanceFormat6Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat6Choice.EligibleBalance),nameof(BalanceFormat6Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat6Choice.NotEligibleBalance),nameof(BalanceFormat6Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat6Choice.FullPeriodUnits),nameof(BalanceFormat6Choice.FullPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat6Choice.PartWayPeriodUnits),nameof(BalanceFormat6Choice.PartWayPeriodUnits))]
    [IsoId("_k7YK1zq5EeWQ1Y7f8kds2A")]
    [DisplayName("Balance Format 6 Choice")]
    public abstract partial record BalanceFormat6Choice_
    {
    }
}
