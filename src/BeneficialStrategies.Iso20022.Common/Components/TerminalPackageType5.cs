// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Terminal Package Type5.
/// </summary>
[IsoId("_BogXkZHjEe6qwqnYOGEReg")]
[DisplayName("Terminal Package Type5")]
public record TerminalPackageType5
{
    /// <summary>
    /// Package.
    /// </summary>
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<PackageType5> Package { get; init; } = [];

    /// <summary>
    /// POI Component Identification.
    /// </summary>
    [DisplayName("POI Component Identification")]
    [IsoXmlTag("POICmpntId")]
    public ValueList<PointOfInteractionComponentIdentification2> POIComponentIdentification { get; init; } =
        [];
}
