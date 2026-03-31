// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat1Choice.Balance))]
    [KnownType(typeof(BalanceFormat1Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat1Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat1Choice.Balance), nameof(BalanceFormat1Choice.Balance))]
    [JsonDerivedType(
        typeof(BalanceFormat1Choice.EligibleBalance),
        nameof(BalanceFormat1Choice.EligibleBalance)
    )]
    [JsonDerivedType(
        typeof(BalanceFormat1Choice.NotEligibleBalance),
        nameof(BalanceFormat1Choice.NotEligibleBalance)
    )]
    [IsoId("_Q0of-tp-Ed-ak6NoX_4Aeg_86295556")]
    [DisplayName("Balance Format 1 Choice")]
    public abstract record BalanceFormat1Choice_ { }
}
