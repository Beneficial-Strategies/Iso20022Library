// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Notification to the acquirer of the completion of the card payment at the acceptor.
/// </summary>
[IsoId("_PkGRYTJKEeOkpIB9tKITlw")]
[DisplayName("Acceptor Completion Advice")]
public record AcceptorCompletionAdvice3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_PzuBwTJKEeOkpIB9tKITlw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment22 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_PzuBwzJKEeOkpIB9tKITlw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext6? Context { get; init; }

    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_PzuBxTJKEeOkpIB9tKITlw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction25 Transaction { get; init; }
}
