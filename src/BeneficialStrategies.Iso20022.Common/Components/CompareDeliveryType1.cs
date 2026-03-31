// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a delivery type.
/// </summary>
[IsoId("_-R_SsExbEeywvc16MwOPfw")]
[DisplayName("Compare Delivery Type")]
public record CompareDeliveryType1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_EsDzIExcEeywvc16MwOPfw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public PhysicalTransferType4Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_G6uqIExcEeywvc16MwOPfw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public PhysicalTransferType4Code? Value2 { get; init; }
}
