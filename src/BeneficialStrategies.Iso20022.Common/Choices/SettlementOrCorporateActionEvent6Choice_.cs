// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent6Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent6Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent6Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent6Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent6Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent6Choice.CorporateActionEventType))]
    [IsoId("_fw8X__vmEeCBQp5TnX1XKQ")]
    [DisplayName("Settlement Or Corporate Action Event 6 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent6Choice_
    {
    }
}
