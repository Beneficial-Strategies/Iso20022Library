// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the unadjusted effective and end date of the schedule.
/// </summary>
[IsoId("_evIKUQbIEeqrW7Meu5r3kQ")]
[DisplayName("Schedule")]
public record Schedule2
{
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
    /// </summary>
    [IsoId("_e3D-UQbIEeqrW7Meu5r3kQ")]
    [DisplayName("Unadjusted Effective Date")]
    [IsoXmlTag("UadjstdFctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate UnadjustedEffectiveDate { get; init; }

    /// <summary>
    /// Indicates the end date agreed in the derivative transaction without adjustment.
    /// </summary>
    [IsoId("_e3D-UwbIEeqrW7Meu5r3kQ")]
    [DisplayName("Unadjusted End Date")]
    [IsoXmlTag("UadjstdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UnadjustedEndDate { get; init; }

    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_e3D-VQbIEeqrW7Meu5r3kQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public required IsoLongFraction19DecimalNumber Quantity { get; init; }
}
