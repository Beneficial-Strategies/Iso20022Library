// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of software packages related to a group of POIComponent of the POI System.
/// </summary>
[IsoId("_SwmVwXIhEe299ZbWCkdR_w")]
[DisplayName("Terminal Package Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TerminalPackageType4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_S79RMXIhEe299ZbWCkdR_w")]
    [DisplayName("POI Component Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICmpntId")]
    #endif
    [IsoXmlTag("POICmpntId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentIdentification2? POIComponentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentIdentification2? POIComponentIdentification { get; init; } 
    #else
    public PointOfInteractionComponentIdentification2? POIComponentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_S79RM3IhEe299ZbWCkdR_w")]
    [DisplayName("Package")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Packg")]
    #endif
    [IsoXmlTag("Packg")]
    public ValueList<PackageType4> Package { get; init; } = new ValueList<PackageType4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _S79RM3IhEe299ZbWCkdR_w
    
    
    #nullable disable
    
}
