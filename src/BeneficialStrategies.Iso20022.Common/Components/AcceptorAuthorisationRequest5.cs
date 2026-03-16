// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation request from an acceptor.
/// </summary>
[IsoId("_XBwmUY0QEeWRYffwL7E13A")]
[DisplayName("Acceptor Authorisation Request")]
public record AcceptorAuthorisationRequest5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_XMpAoY0QEeWRYffwL7E13A")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment45 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_XMpAo40QEeWRYffwL7E13A")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext14 Context { get; init; }

    /// <summary>
    /// Card payment transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_XMpApY0QEeWRYffwL7E13A")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction51 Transaction { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_XMpAp40QEeWRYffwL7E13A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
