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
[IsoId("_xUxwkS8SEeu125Ip9zFcsQ")]
[DisplayName("Terminal Package Type")]
public partial record TerminalPackageType2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_xgNkgS8SEeu125Ip9zFcsQ")]
    [DisplayName("POI Component Identification")]
    [IsoXmlTag("POICmpntId")]
    public PointOfInteractionComponentIdentification2? POIComponentIdentification { get; init; } 
    
    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_xgNkgy8SEeu125Ip9zFcsQ")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<PackageType2> Package { get; init; } = new ValueList<PackageType2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _xgNkgy8SEeu125Ip9zFcsQ
    
    
    #nullable disable
    
}
