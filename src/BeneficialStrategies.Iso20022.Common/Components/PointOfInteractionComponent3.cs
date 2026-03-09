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
/// Data related to a component of the POI performing the transaction.
/// </summary>
[IsoId("_mhI4IAySEeK5P9Ihqok3VA")]
[DisplayName("Point Of Interaction Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponent3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteractionComponent3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteractionComponent3( POIComponentType3Code reqType,PointOfInteractionComponentIdentification1 reqIdentification )
    {
        Type = reqType;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI Terminal.
    /// </summary>
    [IsoId("_1uTl4AySEeK5P9Ihqok3VA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required POIComponentType3Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required POIComponentType3Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POIComponentType3Code Type { get; init; } 
    #else
    public POIComponentType3Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI component.
    /// </summary>
    [IsoId("_EZQXYAyTEeK5P9Ihqok3VA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteractionComponentIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfInteractionComponentIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentIdentification1 Identification { get; init; } 
    #else
    public PointOfInteractionComponentIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the POI component.
    /// </summary>
    [IsoId("_YFaY8AyTEeK5P9Ihqok3VA")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentStatus1? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentStatus1? Status { get; init; } 
    #else
    public PointOfInteractionComponentStatus1? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_r4fh4AyTEeK5P9Ihqok3VA")]
    [DisplayName("Standard Compliance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdCmplc")]
    #endif
    [IsoXmlTag("StdCmplc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification48? StandardCompliance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification48? StandardCompliance { get; init; } 
    #else
    public GenericIdentification48? StandardCompliance { get; set; } 
    #endif
    
    /// <summary>
    /// Characteristics of a POI component.
    /// </summary>
    [IsoId("_4DJg4AyTEeK5P9Ihqok3VA")]
    [DisplayName("Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrtcs")]
    #endif
    [IsoXmlTag("Chrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentCharacteristics1? Characteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentCharacteristics1? Characteristics { get; init; } 
    #else
    public PointOfInteractionComponentCharacteristics1? Characteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_QtXX4AyUEeK5P9Ihqok3VA")]
    [DisplayName("Assessment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assmnt")]
    #endif
    [IsoXmlTag("Assmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentAssessment1? Assessment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentAssessment1? Assessment { get; init; } 
    #else
    public PointOfInteractionComponentAssessment1? Assessment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
