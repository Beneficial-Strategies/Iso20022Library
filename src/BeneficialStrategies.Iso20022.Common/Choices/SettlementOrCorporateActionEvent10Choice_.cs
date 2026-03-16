// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent10Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent10Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent10Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent10Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent10Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent10Choice.CorporateActionEventType)
    )]
    [IsoId("_tF4tARHAEeKHC-9MYSJwtQ")]
    [DisplayName("Settlement Or Corporate Action Event 10 Choice")]
    public abstract record SettlementOrCorporateActionEvent10Choice_ { }
}
