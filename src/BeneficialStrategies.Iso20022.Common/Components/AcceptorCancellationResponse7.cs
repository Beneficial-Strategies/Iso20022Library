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
[IsoId("_4d3zMdtSEee9e6xduATmQg")]
[DisplayName("Acceptor Cancellation Response")]
public record AcceptorCancellationResponse7
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_4mwpcdtSEee9e6xduATmQg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment69 Environment { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_4mwpc9tSEee9e6xduATmQg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction57 Transaction { get; init; }

    /// <summary>
    /// Response from the acquirer to the cancellation transaction.
    /// </summary>
    [IsoId("_4mwpddtSEee9e6xduATmQg")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required CardPaymentTransaction68 TransactionResponse { get; init; }
}
