// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acknowledgement by the acquirer, of the completion advice of the card payment at the acceptor.
/// </summary>
[IsoId("_rXIfkQudEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Completion Advice Response")]
public record AcceptorCompletionAdviceResponse8
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_rjVvkQudEeqw5uEXxQ9H4g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; }

    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_rjVvkwudEeqw5uEXxQ9H4g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse7 Transaction { get; init; }

    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    [IsoId("_rjVvlQudEeqw5uEXxQ9H4g")]
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_rjVvlwudEeqw5uEXxQ9H4g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
