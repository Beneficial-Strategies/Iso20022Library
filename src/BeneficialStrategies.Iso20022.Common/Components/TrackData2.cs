// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Magnetic track or equivalent payment card data.
/// </summary>
[IsoId("_H0Q5wdkMEeiojJsa6FYyew")]
[DisplayName("Track Data")]
public record TrackData2
{
    /// <summary>
    /// Track number of the card.
    /// </summary>
    [IsoId("_H9ypMdkMEeiojJsa6FYyew")]
    [DisplayName("Track Number")]
    [IsoXmlTag("TrckNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TrackNumber { get; init; }

    /// <summary>
    /// Card or check track format.
    /// </summary>
    [IsoId("_WkLq0NkMEeiojJsa6FYyew")]
    [DisplayName("Track Format")]
    [IsoXmlTag("TrckFrmt")]
    public TrackFormat1Code? TrackFormat { get; init; }

    /// <summary>
    /// Card track content or equivalent.
    /// </summary>
    [IsoId("_H9ypM9kMEeiojJsa6FYyew")]
    [DisplayName("Track Value")]
    [IsoXmlTag("TrckVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text TrackValue { get; init; }
}
