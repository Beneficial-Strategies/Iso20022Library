// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent21Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent21Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent21Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent21Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent21Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent21Choice.CorporateActionEventType)
    )]
    [IsoId("_zmv3zZwxEeazcsnODTksnQ")]
    [DisplayName("Settlement Or Corporate Action Event 21 Choice")]
    public abstract record SettlementOrCorporateActionEvent21Choice_ { }
}
