// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement details to determine whether payment is a credit or debit.
    /// </summary>
    [KnownType(typeof(SettlementMethod1Choice.Credit))]
    [KnownType(typeof(SettlementMethod1Choice.Debit))]
    [JsonDerivedType(
        typeof(SettlementMethod1Choice.Credit),
        nameof(SettlementMethod1Choice.Credit)
    )]
    [JsonDerivedType(typeof(SettlementMethod1Choice.Debit), nameof(SettlementMethod1Choice.Debit))]
    [IsoId("_alSkAQ2uEeSNWNtJlXOAhg")]
    [DisplayName("Settlement Method 1 Choice")]
    public abstract record SettlementMethod1Choice_ { }
}
