// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement Or Corporate Action Event35Choice.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent35Choice.CorporateActionEventType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent35Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent35Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent35Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent35Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent35Choice.SecuritiesTransactionType))]
    [IsoId("_muL3gYybEe-PVZsedaAGaA")]
    [DisplayName("Settlement Or Corporate Action Event35Choice")]
    public abstract partial record SettlementOrCorporateActionEvent35Choice_
    {
    }
}
