// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card transaction is performed.
/// </summary>
[IsoId("_fGW8kYO8EeSWSLYdc10LRg")]
[DisplayName("Card Transaction Context")]
public record CardTransactionContext3
{
    /// <summary>
    /// Context of the card transaction.
    /// </summary>
    [IsoId("_fSukoYO8EeSWSLYdc10LRg")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required CardTransactionContext4 TransactionContext { get; init; }
}
