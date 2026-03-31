// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transaction type, corporate action event and settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent32Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent32Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent32Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent32Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent32Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent32Choice.CorporateActionEventType)
    )]
    [IsoId("_ipRlwAVVEeqjd8n6wD9JVw")]
    [DisplayName("Settlement Or Corporate Action Event 32 Choice")]
    public abstract record SettlementOrCorporateActionEvent32Choice_ { }
}
