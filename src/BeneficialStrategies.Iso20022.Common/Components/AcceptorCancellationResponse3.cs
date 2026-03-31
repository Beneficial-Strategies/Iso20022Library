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
[IsoId("_UQGakTJXEeO58eY-wGOnqw")]
[DisplayName("Acceptor Cancellation Response")]
public record AcceptorCancellationResponse3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Ug6dwTJXEeO58eY-wGOnqw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment21 Environment { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_Ug6dwzJXEeO58eY-wGOnqw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction35 Transaction { get; init; }

    /// <summary>
    /// Response from the acquirer to the cancellation transaction.
    /// </summary>
    [IsoId("_Ug6dxTJXEeO58eY-wGOnqw")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required CardPaymentTransaction27 TransactionResponse { get; init; }
}
