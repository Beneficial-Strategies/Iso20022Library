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
[IsoId("_qHOQsS5BEeunNvJlR_vCbg")]
[DisplayName("Acceptor Cancellation Advice")]
public record AcceptorCancellationAdvice10
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_qXC1YS5BEeunNvJlR_vCbg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_qXC1Yy5BEeunNvJlR_vCbg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext28? Context { get; init; }

    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_qXC1ZS5BEeunNvJlR_vCbg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction104 Transaction { get; init; }
}
