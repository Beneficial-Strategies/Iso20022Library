// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of software packages related to a group of POIComponent of the POI System.
/// </summary>
[IsoId("_SwmVwXIhEe299ZbWCkdR_w")]
[DisplayName("Terminal Package Type")]
public partial record TerminalPackageType4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_S79RMXIhEe299ZbWCkdR_w")]
    [DisplayName("POI Component Identification")]
    [IsoXmlTag("POICmpntId")]
    public PointOfInteractionComponentIdentification2? POIComponentIdentification { get; init; } 
    
    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_S79RM3IhEe299ZbWCkdR_w")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<PackageType4> Package { get; init; } = [];
    // ID for the above is _S79RM3IhEe299ZbWCkdR_w
    
    
    #nullable disable
    
}
