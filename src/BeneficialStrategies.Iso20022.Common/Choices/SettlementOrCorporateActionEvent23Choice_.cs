// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent23Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent23Choice.CorporateActionEventType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent23Choice.SecuritiesTransactionType),nameof(SettlementOrCorporateActionEvent23Choice.SecuritiesTransactionType))]
    [JsonDerivedType(typeof(SettlementOrCorporateActionEvent23Choice.CorporateActionEventType),nameof(SettlementOrCorporateActionEvent23Choice.CorporateActionEventType))]
    [IsoId("_xpNoQaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Settlement Or Corporate Action Event 23 Choice")]
    public abstract partial record SettlementOrCorporateActionEvent23Choice_
    {
    }
}
