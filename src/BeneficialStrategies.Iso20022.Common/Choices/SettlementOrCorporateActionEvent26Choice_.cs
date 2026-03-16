// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transaction type, corporate action event and settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent26Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent26Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent26Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent26Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent26Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent26Choice.CorporateActionEventType)
    )]
    [IsoId("_eA1Q7dEfEeiO-eodGv5iKQ")]
    [DisplayName("Settlement Or Corporate Action Event 26 Choice")]
    public abstract record SettlementOrCorporateActionEvent26Choice_ { }
}
