// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent14Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent14Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent14Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent14Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent14Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent14Choice.CorporateActionEventType)
    )]
    [IsoId("_-e-JczqDEeWVrPy0StzzSg")]
    [DisplayName("Settlement Or Corporate Action Event 14 Choice")]
    public abstract record SettlementOrCorporateActionEvent14Choice_ { }
}
