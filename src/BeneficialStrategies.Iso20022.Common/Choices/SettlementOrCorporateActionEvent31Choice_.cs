// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between transaction type, corporate action event and settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent31Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent31Choice.CorporateActionEventType))]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent31Choice.SecuritiesTransactionType),
        nameof(SettlementOrCorporateActionEvent31Choice.SecuritiesTransactionType)
    )]
    [JsonDerivedType(
        typeof(SettlementOrCorporateActionEvent31Choice.CorporateActionEventType),
        nameof(SettlementOrCorporateActionEvent31Choice.CorporateActionEventType)
    )]
    [IsoId("_fOXgDemrEemUgrefIx730g")]
    [DisplayName("Settlement Or Corporate Action Event 31 Choice")]
    public abstract record SettlementOrCorporateActionEvent31Choice_ { }
}
