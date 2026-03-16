// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of a financial authorisation.
/// </summary>
[IsoId("_eBZDMHumEeSBS-QFUaKA-g")]
[DisplayName("Acquirer Financial Response")]
public record AcquirerFinancialResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_vf46YHumEeSBS-QFUaKA-g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardTransactionEnvironment2 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_P5rhkIO9EeSWSLYdc10LRg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardTransactionContext3? Context { get; init; }

    /// <summary>
    /// Card transaction for which the financial authorisation has been requested.
    /// </summary>
    [IsoId("_y_GzQHumEeSBS-QFUaKA-g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardTransaction6 Transaction { get; init; }
}
