// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transaction type, corporate action event and settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent33Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent33Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent33Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent33Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent33Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent33Choice.CorporateActionEventType))]
    [IsoId("_s9qhPAVVEeqjd8n6wD9JVw")]
    [DisplayName("Settlement Or Corporate Action Event 33 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent33Choice_
    {
    }
}
