// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transaction type, corporate action event and settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent30Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent30Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent30Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent30Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent30Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent30Choice.CorporateActionEventType))]
    [IsoId("_Y774semrEemUgrefIx730g")]
    [DisplayName("Settlement Or Corporate Action Event 30 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent30Choice_
    {
    }
}
