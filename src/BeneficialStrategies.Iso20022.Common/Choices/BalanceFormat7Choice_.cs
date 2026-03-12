// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between balance, eligible balance and not eligible balance formats.
    /// </summary>
    [KnownType(typeof(BalanceFormat7Choice.Balance))]
    [KnownType(typeof(BalanceFormat7Choice.EligibleBalance))]
    [KnownType(typeof(BalanceFormat7Choice.NotEligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat7Choice.Balance),nameof(BalanceFormat7Choice.Balance))]
    [JsonDerivedType(typeof(BalanceFormat7Choice.EligibleBalance),nameof(BalanceFormat7Choice.EligibleBalance))]
    [JsonDerivedType(typeof(BalanceFormat7Choice.NotEligibleBalance),nameof(BalanceFormat7Choice.NotEligibleBalance))]
    [IsoId("_cfsErZKQEeWHWpTQn1FFVg")]
    [DisplayName("Balance Format 7 Choice")]
    public abstract partial record BalanceFormat7Choice_
    {
    }
}
