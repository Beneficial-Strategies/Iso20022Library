// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent13Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent13Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent13Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent13Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent13Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent13Choice.CorporateActionEventType)
    )]
    [IsoId("_10WisTqDEeWVrPy0StzzSg")]
    [DisplayName("Settlement Or Corporate Action Event 13 Choice")]
    public abstract record SettlementOrCorporateActionEvent13Choice_ { }
}
