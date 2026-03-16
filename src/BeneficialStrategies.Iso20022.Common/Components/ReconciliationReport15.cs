// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation Report15.
/// </summary>
[IsoId("_BVEY95BIEe6Ojt1b3tfu9Q")]
[DisplayName("Reconciliation Report15")]
public record ReconciliationReport15
{
    /// <summary>
    /// Matching Criteria.
    /// </summary>
    [DisplayName("Matching Criteria")]
    [IsoXmlTag("MtchgCrit")]
    public required MatchingCriteria17 MatchingCriteria { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; }
}
