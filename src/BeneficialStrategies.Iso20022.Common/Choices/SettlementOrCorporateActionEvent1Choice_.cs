// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent1Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent1Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent1Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent1Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent1Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent1Choice.CorporateActionEventType))]
    [IsoId("_QwUApdp-Ed-ak6NoX_4Aeg_1179810715")]
    [DisplayName("Settlement Or Corporate Action Event 1 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent1Choice_
    {
    }
}
