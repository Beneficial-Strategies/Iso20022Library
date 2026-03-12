// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent9Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent9Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent9Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent9Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent9Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent9Choice.CorporateActionEventType))]
    [IsoId("_Izye0RG-EeKHC-9MYSJwtQ")]
    [DisplayName("Settlement Or Corporate Action Event 9 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent9Choice_
    {
    }
}
