// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent16Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent16Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent16Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent16Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent16Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent16Choice.CorporateActionEventType))]
    [IsoId("_8bir7ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Or Corporate Action Event 16 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent16Choice_
    {
    }
}
