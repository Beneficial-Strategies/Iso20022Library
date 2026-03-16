// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent20Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent20Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent20Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent20Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent20Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent20Choice.CorporateActionEventType)
    )]
    [IsoId("_pAgPoZwxEeazcsnODTksnQ")]
    [DisplayName("Settlement Or Corporate Action Event 20 Choice")]
    public abstract record SettlementOrCorporateActionEvent20Choice_ { }
}
