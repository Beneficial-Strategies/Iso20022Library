// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment status details.
/// </summary>
[IsoId("_NhZZ05lPEee-Zps0fZQaFQ")]
[DisplayName("Payment Status")]
public record PaymentStatus3
{
    /// <summary>
    /// Status of a transfer, in coded form, as assigned by the transaction administrator.
    /// </summary>
    [IsoId("_NqBxQ5lPEee-Zps0fZQaFQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public PaymentStatusCode6Choice_? Code { get; init; }

    /// <summary>
    /// Date and time at which the status was assigned to the transfer.
    /// </summary>
    [IsoId("_NqBxRZlPEee-Zps0fZQaFQ")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public DateAndDateTime2Choice_? DateTime { get; init; }

    /// <summary>
    /// Reason provided for the status of a transfer.
    /// </summary>
    [IsoId("_NqBxR5lPEee-Zps0fZQaFQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public PaymentStatusReasonCode7Choice_? Reason { get; init; }
}
