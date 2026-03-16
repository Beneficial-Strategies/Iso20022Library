// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transaction type, corporate action event and settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent29Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent29Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent29Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent29Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent29Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent29Choice.CorporateActionEventType)
    )]
    [IsoId("_sanT8_fZEeiNZp_PtLohLw")]
    [DisplayName("Settlement Or Corporate Action Event 29 Choice")]
    public abstract record SettlementOrCorporateActionEvent29Choice_ { }
}
