// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent2Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent2Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent2Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent2Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent2Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent2Choice.CorporateActionEventType))]
    [IsoId("_QtevFNp-Ed-ak6NoX_4Aeg_-286184680")]
    [DisplayName("Settlement Or Corporate Action Event 2 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent2Choice_
    {
    }
}
