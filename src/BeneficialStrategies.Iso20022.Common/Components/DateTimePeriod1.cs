// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
[IsoId("_aeAZM_hvEeSLI7Du5Hk4iw")]
[DisplayName("Date Time Period")]
public record DateTimePeriod1
{
    /// <summary>
    /// Date and time at which the period starts.
    /// </summary>
    [IsoId("_aeAZNPhvEeSLI7Du5Hk4iw")]
    [DisplayName("From Date Time")]
    [IsoXmlTag("FrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime FromDateTime { get; init; }

    /// <summary>
    /// Date and time at which the period ends.
    /// </summary>
    [IsoId("_aeAZNfhvEeSLI7Du5Hk4iw")]
    [DisplayName("To Date Time")]
    [IsoXmlTag("ToDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ToDateTime { get; init; }
}
