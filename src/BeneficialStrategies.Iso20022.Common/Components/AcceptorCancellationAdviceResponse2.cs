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
[IsoId("_G8IDMQvXEeKzJ69IWwzB9Q")]
[DisplayName("Acceptor Cancellation Advice Response")]
public record AcceptorCancellationAdviceResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_HHSKUQvXEeKzJ69IWwzB9Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment11 Environment { get; init; }

    /// <summary>
    /// Cancellation transaction from an acceptor to the acquirer.
    /// </summary>
    [IsoId("_HHSKVQvXEeKzJ69IWwzB9Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse3 Transaction { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_HHSKWQvXEeKzJ69IWwzB9Q")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
