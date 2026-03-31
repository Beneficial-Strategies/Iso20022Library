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
[IsoId("_X5bM8XJyEe299ZbWCkdR_w")]
[DisplayName("Acceptor Cancellation Response")]
public record AcceptorCancellationResponse11
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_X_3zMXJyEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_X_3zM3JyEe299ZbWCkdR_w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction117 Transaction { get; init; }

    /// <summary>
    /// Response from the acquirer to the cancellation transaction.
    /// </summary>
    [IsoId("_X_3zNXJyEe299ZbWCkdR_w")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required CardPaymentTransaction130 TransactionResponse { get; init; }
}
