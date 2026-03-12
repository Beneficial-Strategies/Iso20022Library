// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent24Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent24Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent24Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent24Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent24Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent24Choice.CorporateActionEventType))]
    [IsoId("_7k6mLc32Eee5nJBZsW8MFQ")]
    [DisplayName("Settlement Or Corporate Action Event 24 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent24Choice_
    {
    }
}
