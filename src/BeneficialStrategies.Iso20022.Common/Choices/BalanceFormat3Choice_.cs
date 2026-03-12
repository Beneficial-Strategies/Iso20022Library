// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat3Choice.Balance))]
    [KnownType(typeof(BalanceFormat3Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat3Choice.NotEligibleBalance))]
    [KnownType(typeof(BalanceFormat3Choice.FullPeriodUnits))]
    [KnownType(typeof(BalanceFormat3Choice.PartWayPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat3Choice.Balance),nameof(BalanceFormat3Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat3Choice.EligibleBalance),nameof(BalanceFormat3Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat3Choice.NotEligibleBalance),nameof(BalanceFormat3Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat3Choice.FullPeriodUnits),nameof(BalanceFormat3Choice.FullPeriodUnits))]
    [JsonDerivedType(typeof(BalanceFormat3Choice.PartWayPeriodUnits),nameof(BalanceFormat3Choice.PartWayPeriodUnits))]
    [IsoId("_2-A6IRFPEeKp2ZN13DI_pA")]
    [DisplayName("Balance Format 3 Choice")]
    public abstract partial record BalanceFormat3Choice_
    {
    }
}
