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
[IsoId("_JLNw0a3NEeey8N0JWnVPUw")]
[DisplayName("Date Time Period Details")]
public record DateTimePeriodDetails2
{
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_JWX38a3NEeey8N0JWnVPUw")]
    [DisplayName("From Date Time")]
    [IsoXmlTag("FrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime FromDateTime { get; init; }

    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_JWX3863NEeey8N0JWnVPUw")]
    [DisplayName("To Date Time")]
    [IsoXmlTag("ToDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ToDateTime { get; init; }
}
