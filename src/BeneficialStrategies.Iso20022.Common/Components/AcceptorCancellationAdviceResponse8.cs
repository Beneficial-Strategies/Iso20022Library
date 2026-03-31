// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation advice response from the acquirer.
/// </summary>
[IsoId("_oy0QEQuaEeqYM5yH99IYQw")]
[DisplayName("Acceptor Cancellation Advice Response")]
public record AcceptorCancellationAdviceResponse8
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_o9kukQuaEeqYM5yH99IYQw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; }

    /// <summary>
    /// Cancellation transaction from an acceptor to the acquirer.
    /// </summary>
    [IsoId("_o9kukwuaEeqYM5yH99IYQw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse7 Transaction { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_o9kulQuaEeqYM5yH99IYQw")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
