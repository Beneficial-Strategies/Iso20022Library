// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement details to determine whether payment is a credit or debit.
    /// </summary>
    [KnownType(typeof(SettlementMethod4Choice.Credit))]
    [KnownType(typeof(SettlementMethod4Choice.Debit))]
    [JsonDerivedType(
        typeof(SettlementMethod4Choice.Credit),
        nameof(SettlementMethod4Choice.Credit)
    )]
    [JsonDerivedType(typeof(SettlementMethod4Choice.Debit), nameof(SettlementMethod4Choice.Debit))]
    [IsoId("_dWm-h9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Method 4 Choice")]
    public abstract record SettlementMethod4Choice_ { }
}
