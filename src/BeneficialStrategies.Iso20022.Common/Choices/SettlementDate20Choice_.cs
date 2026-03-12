// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate20Choice.Date))]
    [KnownType(typeof(SettlementDate20Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate20Choice.Date),nameof(SettlementDate20Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate20Choice.DateCode),nameof(SettlementDate20Choice.DateCode))]
    [IsoId("_qImeT83yEee5nJBZsW8MFQ")]
    [DisplayName("Settlement Date 20 Choice")]
    public abstract partial record SettlementDate20Choice_
    {
    }
}
