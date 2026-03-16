// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment instrument for a type of order.
/// </summary>
[IsoId("_q3QsMF8rEeicg40_9gK9vQ")]
[DisplayName("Payment Instrument")]
public record PaymentInstrument16
{
    /// <summary>
    /// Type of order to which the payment instrument applies.
    /// </summary>
    [IsoId("_FhZzkF8sEeicg40_9gK9vQ")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public required FundOrderType5Choice_ OrderType { get; init; }

    /// <summary>
    /// Payment instrument for the order type.
    /// </summary>
    [IsoId("_oIpUYF8sEeicg40_9gK9vQ")]
    [DisplayName("Instrument Type")]
    [IsoXmlTag("InstrmTp")]
    public required FundPaymentType1Choice_ InstrumentType { get; init; }

    /// <summary>
    /// Additional information about the payment.
    /// </summary>
    [IsoId("_xXAigWAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
