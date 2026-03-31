// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation request from an acceptor.
/// </summary>
[IsoId("_Zgm00QubEeqYM5yH99IYQw")]
[DisplayName("Acceptor Cancellation Request")]
public record AcceptorCancellationRequest9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_ZsfUsQubEeqYM5yH99IYQw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_ZsfUswubEeqYM5yH99IYQw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_ZsfUtQubEeqYM5yH99IYQw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction96 Transaction { get; init; }
}
