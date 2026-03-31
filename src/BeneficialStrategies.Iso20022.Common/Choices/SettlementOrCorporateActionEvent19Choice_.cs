// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent19Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent19Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent19Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent19Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent19Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent19Choice.CorporateActionEventType)
    )]
    [IsoId("_5pmV4ZBPEeakHoV5BVecAQ")]
    [DisplayName("Settlement Or Corporate Action Event 19 Choice")]
    public abstract record SettlementOrCorporateActionEvent19Choice_ { }
}
