// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional information about the fuel location, such as hours of operation and Interstate Access/Exit Number, etc.
/// </summary>
[IsoId("_UL3KoXbhEfCmC4yYaU27Kg")]
[DisplayName("Local Amenity2")]
public record LocalAmenity2
{
    /// <summary>
    /// Type of additional service available. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_UOb9gXbhEfCmC4yYaU27Kg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required LocationAmenity2Code Type { get; init; }

    /// <summary>
    /// Indicates whether or not a specific type of amenity is available at this location.
    /// </summary>
    [IsoId("_UOb9hXbhEfCmC4yYaU27Kg")]
    [DisplayName("Available Indicator")]
    [IsoXmlTag("AvlblInd")]
    public IsoTrueFalseIndicator? AvailableIndicator { get; init; }
}
