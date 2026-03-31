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
[IsoId("_yu6VwS1xEeuZtpnZJ4v-5Q")]
[DisplayName("Acceptor Cancellation Advice Response")]
public record AcceptorCancellationAdviceResponse9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_y6decS1xEeuZtpnZJ4v-5Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Cancellation transaction from an acceptor to the acquirer.
    /// </summary>
    [IsoId("_y6decy1xEeuZtpnZJ4v-5Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse8 Transaction { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_y6dedS1xEeuZtpnZJ4v-5Q")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }
}
