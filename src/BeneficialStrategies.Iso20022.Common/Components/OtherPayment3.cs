// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment related to elements not reported in dedicated fields.
/// </summary>
[IsoId("_R72T8XhSEeu3kecHd7QKUQ")]
[DisplayName("Other Payment")]
public record OtherPayment3
{
    /// <summary>
    /// Amount of money of any payment the reporting counterparty made or received.
    /// Usage: The negative symbol to be used to indicate that the payment was made, not received.
    /// </summary>
    [IsoId("_SKRxgXhSEeu3kecHd7QKUQ")]
    [DisplayName("Payment Amount")]
    [IsoXmlTag("PmtAmt")]
    public required AmountAndDirection106 PaymentAmount { get; init; }

    /// <summary>
    /// Indicates the type of other payment.
    /// </summary>
    [IsoId("_SKRxg3hSEeu3kecHd7QKUQ")]
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public PaymentType5Choice_? PaymentType { get; init; }

    /// <summary>
    /// Indicates the unadjusted date on which the other payment is paid.
    /// </summary>
    [IsoId("_SKRxhXhSEeu3kecHd7QKUQ")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PaymentDate { get; init; }

    /// <summary>
    /// Identifies the payer of the other payment amount.
    /// </summary>
    [IsoId("_SKRxh3hSEeu3kecHd7QKUQ")]
    [DisplayName("Payment Payer")]
    [IsoXmlTag("PmtPyer")]
    public PartyIdentification235Choice_? PaymentPayer { get; init; }

    /// <summary>
    /// Identifies the receiver of the other payment amount.
    /// </summary>
    [IsoId("_SKRxiXhSEeu3kecHd7QKUQ")]
    [DisplayName("Payment Receiver")]
    [IsoXmlTag("PmtRcvr")]
    public PartyIdentification235Choice_? PaymentReceiver { get; init; }
}
