// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent25Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent25Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent25Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent25Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent25Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent25Choice.CorporateActionEventType)
    )]
    [IsoId("_gdPZP833Eee5nJBZsW8MFQ")]
    [DisplayName("Settlement Or Corporate Action Event 25 Choice")]
    public abstract record SettlementOrCorporateActionEvent25Choice_ { }
}
