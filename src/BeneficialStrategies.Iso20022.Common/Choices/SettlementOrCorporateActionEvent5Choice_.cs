// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent5Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent5Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent5Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent5Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent5Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent5Choice.CorporateActionEventType)
    )]
    [IsoId("_PlRa6fvmEeCBQp5TnX1XKQ")]
    [DisplayName("Settlement Or Corporate Action Event 5 Choice")]
    public abstract record SettlementOrCorporateActionEvent5Choice_ { }
}
