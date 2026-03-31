// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation response from the acquirer.
/// </summary>
[IsoId("_YYGJgY1EEeWsypzzYao74A")]
[DisplayName("Acceptor Cancellation Response")]
public record AcceptorCancellationResponse5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_YihQ0Y1EEeWsypzzYao74A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment46 Environment { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_YihQ041EEeWsypzzYao74A")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction57 Transaction { get; init; }

    /// <summary>
    /// Response from the acquirer to the cancellation transaction.
    /// </summary>
    [IsoId("_YihQ1Y1EEeWsypzzYao74A")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required CardPaymentTransaction58 TransactionResponse { get; init; }
}
