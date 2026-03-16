// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation transaction between an acceptor and an acquirer.
/// </summary>
[IsoId("_Sv8c4AEcEeCQm6a_G2yO_w_238981867")]
[DisplayName("Acceptor Cancellation Advice")]
public record AcceptorCancellationAdvice1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Sv8c4QEcEeCQm6a_G2yO_w_-1776312141")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment2 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_Sv8c4gEcEeCQm6a_G2yO_w_1883623309")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext2? Context { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_Sv8c4wEcEeCQm6a_G2yO_w_-46612159")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction7 Transaction { get; init; }
}
