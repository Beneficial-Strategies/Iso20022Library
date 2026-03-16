// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about how an order is to be processed.
/// </summary>
[IsoId("_-312EToQEeabspMEjqY5TQ")]
[DisplayName("Order Waiver")]
public record OrderWaiver1
{
    /// <summary>
    /// Reason why the order has to be handled differently, probably in a manual fashion, because, for example, the investment manager has agreed a waiver to the terms.
    /// </summary>
    [IsoId("__Q1k4ToQEeabspMEjqY5TQ")]
    [DisplayName("Order Waiver Reason")]
    [IsoXmlTag("OrdrWvrRsn")]
    public ValueList<OrderWaiverReason3Choice_> OrderWaiverReason { get; init; } = [];

    /// <summary>
    /// Additional information about the order waiver.
    /// </summary>
    [IsoId("__Q1k4zoQEeabspMEjqY5TQ")]
    [DisplayName("Information Value")]
    [IsoXmlTag("InfVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? InformationValue { get; init; }
}
