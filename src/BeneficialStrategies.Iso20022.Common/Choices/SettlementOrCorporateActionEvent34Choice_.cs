// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Settlement Or Corporate Action Event34Choice.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent34Choice.CorporateActionEventType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent34Choice.SecuritiesTransactionType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent34Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent34Choice.CorporateActionEventType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent34Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent34Choice.SecuritiesTransactionType)
    )]
    [IsoId("_me-94YybEe-PVZsedaAGaA")]
    [DisplayName("Settlement Or Corporate Action Event34Choice")]
    public abstract record SettlementOrCorporateActionEvent34Choice_ { }
}
