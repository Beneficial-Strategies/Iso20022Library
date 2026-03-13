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
[IsoId("_3H8fIVFDEeyApZmLzm74zA")]
[DisplayName("Terminal Package Type")]
public partial record TerminalPackageType3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_3OFjYVFDEeyApZmLzm74zA")]
    [DisplayName("POI Component Identification")]
    [IsoXmlTag("POICmpntId")]
    public PointOfInteractionComponentIdentification2? POIComponentIdentification { get; init; } 
    
    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_3OFjY1FDEeyApZmLzm74zA")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<PackageType3> Package { get; init; } = [];
    // ID for the above is _3OFjY1FDEeyApZmLzm74zA
    
    
    #nullable disable
    
}
