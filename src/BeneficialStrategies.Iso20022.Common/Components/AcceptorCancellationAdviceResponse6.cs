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
[IsoId("_aTWxMap5EeanIZ10Ka8PnA")]
[DisplayName("Acceptor Cancellation Advice Response")]
public record AcceptorCancellationAdviceResponse6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_ad83oap5EeanIZ10Ka8PnA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment65 Environment { get; init; }

    /// <summary>
    /// Cancellation transaction from an acceptor to the acquirer.
    /// </summary>
    [IsoId("_ad83o6p5EeanIZ10Ka8PnA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse6 Transaction { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_ad83pap5EeanIZ10Ka8PnA")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
