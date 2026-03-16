// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sensitive data associated with a payment card.
/// </summary>
[IsoId("_VZbFQSFPEey8XKHwKquEQw")]
[DisplayName("Plain Card Data")]
public record PlainCardData21
{
    /// <summary>
    /// Identification of the driver or vehicle.
    /// </summary>
    [IsoId("_VfOyUSFPEey8XKHwKquEQw")]
    [DisplayName("Driver Or Vehicle Identification")]
    [IsoXmlTag("DrvrOrVhclId")]
    [IsoSimpleType(IsoSimpleType.Max20Text)]
    [StringLength(maximumLength: 20, MinimumLength = 1)]
    public IsoMax20Text? DriverOrVehicleIdentification { get; init; }

    /// <summary>
    /// Additional card specific data.
    /// </summary>
    [IsoId("_VfOyUyFPEey8XKHwKquEQw")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    public AdditionalData1? AdditionalCardData { get; init; }
}
