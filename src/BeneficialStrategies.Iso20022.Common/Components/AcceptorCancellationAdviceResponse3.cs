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
[IsoId("_z59yATJcEeO58eY-wGOnqw")]
[DisplayName("Acceptor Cancellation Advice Response")]
public record AcceptorCancellationAdviceResponse3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_0K7mMTJcEeO58eY-wGOnqw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment21 Environment { get; init; }

    /// <summary>
    /// Cancellation transaction from an acceptor to the acquirer.
    /// </summary>
    [IsoId("_0K7mMzJcEeO58eY-wGOnqw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse4 Transaction { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_0K7mNTJcEeO58eY-wGOnqw")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
