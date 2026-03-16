// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a delivery interconnection point.
/// </summary>
[IsoId("_g-BqME6cEeyEpI66tm807w")]
[DisplayName("Compare Delivery Interconnection Point")]
public record CompareDeliveryInterconnectionPoint1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_pRvM0E6cEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public DeliveryInterconnectionPoint1Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_sCby0E6cEeyEpI66tm807w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public DeliveryInterconnectionPoint1Choice_? Value2 { get; init; }
}
