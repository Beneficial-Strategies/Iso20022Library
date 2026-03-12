// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent22Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent22Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent22Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent22Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent22Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent22Choice.CorporateActionEventType))]
    [IsoId("_wszqIaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Settlement Or Corporate Action Event 22 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent22Choice_
    {
    }
}
