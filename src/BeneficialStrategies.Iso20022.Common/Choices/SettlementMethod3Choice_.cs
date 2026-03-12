// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement details to determine whether payment is a credit or debit.
    /// </summary>
    [KnownType(typeof(SettlementMethod3Choice.Credit))]
    [KnownType(typeof(SettlementMethod3Choice.Debit))]
    [JsonDerivedType(typeof(SettlementMethod3Choice.Credit),nameof(SettlementMethod3Choice.Credit))]
    [JsonDerivedType(typeof(SettlementMethod3Choice.Debit),nameof(SettlementMethod3Choice.Debit))]
    [IsoId("_Po-0AcQAEemsic1bQcEtLA")]
    [DisplayName("Settlement Method 3 Choice")]
    public abstract partial record SettlementMethod3Choice_
    {
    }
}
