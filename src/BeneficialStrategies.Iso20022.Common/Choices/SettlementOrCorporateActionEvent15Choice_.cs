// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent15Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent15Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent15Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent15Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent15Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent15Choice.CorporateActionEventType))]
    [IsoId("_8VKXbZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Or Corporate Action Event 15 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent15Choice_
    {
    }
}
