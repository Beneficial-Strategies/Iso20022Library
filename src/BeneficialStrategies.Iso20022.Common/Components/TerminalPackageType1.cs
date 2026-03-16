// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of software packages related to a group of POIComponent of the POI System.
/// </summary>
[IsoId("_zZR7oAueEeqw5uEXxQ9H4g")]
[DisplayName("Terminal Package Type")]
public record TerminalPackageType1
{
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_zCO7IBBgEeqgJK7e3n_EXA")]
    [DisplayName("POI Component Identification")]
    [IsoXmlTag("POICmpntId")]
    public PointOfInteractionComponentIdentification1? POIComponentIdentification { get; init; }

    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_5ti8kBBgEeqgJK7e3n_EXA")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<PackageType1> Package { get; init; } = [];
    // ID for the above is _5ti8kBBgEeqgJK7e3n_EXA
}
