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
/// Data related to a component of the POI (Point Of Interaction) performing the transaction.
/// </summary>
[IsoId("__Mkz8SYBEeym0KcvJF9aDQ")]
[DisplayName("Point Of Interaction Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponent13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteractionComponent13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteractionComponent13( POIComponentType5Code reqType,PointOfInteractionComponentIdentification3 reqIdentification )
    {
        Type = reqType;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("__SG0MSYBEeym0KcvJF9aDQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required POIComponentType5Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required POIComponentType5Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POIComponentType5Code Type { get; init; } 
    #else
    public POIComponentType5Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("__SG0MyYBEeym0KcvJF9aDQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteractionComponentIdentification3 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfInteractionComponentIdentification3 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentIdentification3 Identification { get; init; } 
    #else
    public PointOfInteractionComponentIdentification3 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("__SG0NSYBEeym0KcvJF9aDQ")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentStatus3? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentStatus3? Status { get; init; } 
    #else
    public PointOfInteractionComponentStatus3? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("__SG0NyYBEeym0KcvJF9aDQ")]
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
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("__SG0OSYBEeym0KcvJF9aDQ")]
    [DisplayName("Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrtcs")]
    #endif
    [IsoXmlTag("Chrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentCharacteristics4? Characteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentCharacteristics4? Characteristics { get; init; } 
    #else
    public PointOfInteractionComponentCharacteristics4? Characteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("__SG0OyYBEeym0KcvJF9aDQ")]
    [DisplayName("Assessment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assmnt")]
    #endif
    [IsoXmlTag("Assmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentIdentification3? Assessment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentIdentification3? Assessment { get; init; } 
    #else
    public PointOfInteractionComponentIdentification3? Assessment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
