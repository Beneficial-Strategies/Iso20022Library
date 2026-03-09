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
[IsoId("_zZR7oAueEeqw5uEXxQ9H4g")]
[DisplayName("Terminal Package Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TerminalPackageType1
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
    [IsoId("_zCO7IBBgEeqgJK7e3n_EXA")]
    [DisplayName("POI Component Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICmpntId")]
    #endif
    [IsoXmlTag("POICmpntId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentIdentification1? POIComponentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentIdentification1? POIComponentIdentification { get; init; } 
    #else
    public PointOfInteractionComponentIdentification1? POIComponentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_5ti8kBBgEeqgJK7e3n_EXA")]
    [DisplayName("Package")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Packg")]
    #endif
    [IsoXmlTag("Packg")]
    public ValueList<PackageType1> Package { get; init; } = new ValueList<PackageType1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _5ti8kBBgEeqgJK7e3n_EXA
    
    
    #nullable disable
    
}
