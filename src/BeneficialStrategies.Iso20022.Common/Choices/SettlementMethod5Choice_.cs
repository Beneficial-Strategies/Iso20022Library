// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement Method5Choice.
    /// </summary>
    [KnownType(typeof(SettlementMethod5Choice.Credit))]
    [KnownType(typeof(SettlementMethod5Choice.Debit))]
    [JsonDerivedType(
        typeof(SettlementMethod5Choice.Credit),
        nameof(SettlementMethod5Choice.Credit)
    )]
    [JsonDerivedType(typeof(SettlementMethod5Choice.Debit), nameof(SettlementMethod5Choice.Debit))]
    [IsoId("_8P2h5zEsEe6GxLzpkVnWYg")]
    [DisplayName("Settlement Method5Choice")]
    public abstract record SettlementMethod5Choice_ { }
}
