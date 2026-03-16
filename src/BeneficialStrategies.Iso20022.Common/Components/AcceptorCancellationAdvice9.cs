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
[IsoId("_IwSHsQuaEeqYM5yH99IYQw")]
[DisplayName("Acceptor Cancellation Advice")]
public record AcceptorCancellationAdvice9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_I6t2EQuaEeqYM5yH99IYQw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_I6t2EwuaEeqYM5yH99IYQw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext28? Context { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_I6t2FQuaEeqYM5yH99IYQw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction95 Transaction { get; init; }
}
