// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Particular time span specified between a start time and an end time. The time period cannot exceed 24 hours.
/// </summary>
[IsoId("_xzaSke5pEemXBpiFxCCWFQ")]
[DisplayName("Time Period")]
public record TimePeriod2
{
    /// <summary>
    /// Time at which the time span starts.
    /// </summary>
    [IsoId("_yAj9we5pEemXBpiFxCCWFQ")]
    [DisplayName("From Time")]
    [IsoXmlTag("FrTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime FromTime { get; init; }

    /// <summary>
    /// Time at which the time span ends.
    /// </summary>
    [IsoId("_yAj9w-5pEemXBpiFxCCWFQ")]
    [DisplayName("To Time")]
    [IsoXmlTag("ToTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ToTime { get; init; }
}
