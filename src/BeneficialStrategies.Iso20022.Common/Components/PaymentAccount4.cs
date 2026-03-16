// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Account4.
/// </summary>
[IsoId("_fp7v8TzVEe6P1b-XWVSh4g")]
[DisplayName("Payment Account4")]
public record PaymentAccount4
{
    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }

    /// <summary>
    /// Gross Credits.
    /// </summary>
    [DisplayName("Gross Credits")]
    [IsoXmlTag("GrssCdts")]
    public required ImpliedCurrencyAndAmount GrossCredits { get; init; }

    /// <summary>
    /// Gross Debits.
    /// </summary>
    [DisplayName("Gross Debits")]
    [IsoXmlTag("GrssDbts")]
    public required ImpliedCurrencyAndAmount GrossDebits { get; init; }

    /// <summary>
    /// Late Payment Confirmation.
    /// </summary>
    [DisplayName("Late Payment Confirmation")]
    [IsoXmlTag("LatePmtConf")]
    public required IsoMax10NumericText LatePaymentConfirmation { get; init; }

    /// <summary>
    /// Net Payment.
    /// </summary>
    [DisplayName("Net Payment")]
    [IsoXmlTag("NetPmt")]
    public required AmountAndDirection86 NetPayment { get; init; }
}
