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
[IsoId("_tAsCoVFAEeyApZmLzm74zA")]
[DisplayName("Point Of Interaction Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponent12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteractionComponent12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteractionComponent12( POIComponentType6Code reqType,PointOfInteractionComponentIdentification2 reqIdentification )
    {
        Type = reqType;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("_tHIo4VFAEeyApZmLzm74zA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required POIComponentType6Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required POIComponentType6Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POIComponentType6Code Type { get; init; } 
    #else
    public POIComponentType6Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information regarding the type of the component.
    /// </summary>
    [IsoId("_tHIo41FAEeyApZmLzm74zA")]
    [DisplayName("Sub Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubTpInf")]
    #endif
    [IsoXmlTag("SubTpInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SubTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubTypeInformation { get; init; } 
    #else
    public System.String? SubTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_tHIo5VFAEeyApZmLzm74zA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteractionComponentIdentification2 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfInteractionComponentIdentification2 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentIdentification2 Identification { get; init; } 
    #else
    public PointOfInteractionComponentIdentification2 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_tHIo51FAEeyApZmLzm74zA")]
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
    [IsoId("_tHIo6VFAEeyApZmLzm74zA")]
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
    [IsoId("_tHIo61FAEeyApZmLzm74zA")]
    [DisplayName("Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrtcs")]
    #endif
    [IsoXmlTag("Chrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentCharacteristics8? Characteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentCharacteristics8? Characteristics { get; init; } 
    #else
    public PointOfInteractionComponentCharacteristics8? Characteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_tHIo7VFAEeyApZmLzm74zA")]
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
    
    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_tHIo71FAEeyApZmLzm74zA")]
    [DisplayName("Package")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Packg")]
    #endif
    [IsoXmlTag("Packg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PackageType3? Package { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PackageType3? Package { get; init; } 
    #else
    public PackageType3? Package { get; set; } 
    #endif
    
    
    #nullable disable
    
}
