// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transaction type, corporate action event and settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent27Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent27Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent27Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent27Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent27Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent27Choice.CorporateActionEventType)
    )]
    [IsoId("_U11c0dEmEeiO-eodGv5iKQ")]
    [DisplayName("Settlement Or Corporate Action Event 27 Choice")]
    public abstract record SettlementOrCorporateActionEvent27Choice_ { }
}
