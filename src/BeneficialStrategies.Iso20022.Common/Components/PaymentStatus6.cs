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
[IsoId("_P_d5gdEdEei798TPbKJMuw")]
[DisplayName("Payment Status")]
public record PaymentStatus6
{
    /// <summary>
    /// Status of a transfer, in coded form, as assigned by the transaction administrator.
    /// </summary>
    [IsoId("_QKoAo9EdEei798TPbKJMuw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public PaymentStatusCode6Choice_? Code { get; init; }

    /// <summary>
    /// Date and time at which the status was assigned to the transfer.
    /// </summary>
    [IsoId("_QKoApdEdEei798TPbKJMuw")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public DateAndDateTime2Choice_? DateTime { get; init; }

    /// <summary>
    /// Reason provided for the status of a transfer.
    /// </summary>
    [IsoId("_QKoAp9EdEei798TPbKJMuw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<PaymentStatusReason1Choice_> Reason { get; init; } = [];
}
