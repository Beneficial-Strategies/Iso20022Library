// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent17Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent17Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent17Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent17Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent17Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent17Choice.CorporateActionEventType))]
    [IsoId("_fI9pUYyjEea-QrbCUXny2w")]
    [DisplayName("Settlement Or Corporate Action Event 17 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent17Choice_
    {
    }
}
