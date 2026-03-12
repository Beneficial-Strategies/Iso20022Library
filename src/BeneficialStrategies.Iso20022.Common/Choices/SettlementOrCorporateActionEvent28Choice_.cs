// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transaction type, corporate action event and settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent28Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent28Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent28Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent28Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent28Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent28Choice.CorporateActionEventType))]
    [IsoId("_iE4RXffZEeiNZp_PtLohLw")]
    [DisplayName("Settlement Or Corporate Action Event 28 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent28Choice_
    {
    }
}
