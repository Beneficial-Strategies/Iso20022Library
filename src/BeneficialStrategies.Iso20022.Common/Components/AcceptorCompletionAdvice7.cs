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
[IsoId("_RVHUgdndEeeN3v2fup_Shw")]
[DisplayName("Acceptor Completion Advice")]
public record AcceptorCompletionAdvice7
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_ReQCYdndEeeN3v2fup_Shw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment68 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_ReQCY9ndEeeN3v2fup_Shw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext26? Context { get; init; }

    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_ReQCZdndEeeN3v2fup_Shw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction81 Transaction { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_ReQCZ9ndEeeN3v2fup_Shw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
