// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other Payment6.
/// </summary>
[IsoId("_kq-10SysEe6J0v6OMXVc7g")]
[DisplayName("Other Payment6")]
public record OtherPayment6
{
    /// <summary>
    /// Payment Currency.
    /// </summary>
    [DisplayName("Payment Currency")]
    [IsoXmlTag("PmtCcy")]
    public ActiveOrHistoricCurrencyCode? PaymentCurrency { get; init; }

    /// <summary>
    /// Payment Date.
    /// </summary>
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public IsoISODate? PaymentDate { get; init; }

    /// <summary>
    /// Payment Payer.
    /// </summary>
    [DisplayName("Payment Payer")]
    [IsoXmlTag("PmtPyer")]
    public PartyIdentification236Choice_? PaymentPayer { get; init; }

    /// <summary>
    /// Payment Receiver.
    /// </summary>
    [DisplayName("Payment Receiver")]
    [IsoXmlTag("PmtRcvr")]
    public PartyIdentification236Choice_? PaymentReceiver { get; init; }

    /// <summary>
    /// Payment Type.
    /// </summary>
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public PaymentType5Choice_? PaymentType { get; init; }
}
